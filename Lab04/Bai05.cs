using System.ComponentModel;
using Microsoft.Data.Sqlite;

namespace Lab04;

public partial class Bai05 : Form
{
    private const string DbPath = "students.db";
    private readonly SqliteConnection connection;
    private readonly BindingList<Student> students = [];
    
    public Bai05()
    {
        InitializeComponent();

        connection = new SqliteConnection($"Data Source={DbPath}");
        connection.Open();
        TryCreateTable();
        LoadStudents();
        
        dataGridView1.AutoGenerateColumns = false;
        dataGridView1.DataSource = null;
        dataGridView1.DataSource = students;
        
        menuNewBtn.Click += AddNew;
        toolNewBtn.Click += AddNew;
        
        toolSearchTB.TextChanged += OnSearchChange;

        menuExitBtn.Click += (_, _) => Close();
        FormClosed += SaveAndClose;
    }

    private void AddNew(object? sender, EventArgs e)
    {
        var inputForm = new Bai05_2();
        if (inputForm.ShowDialog() != DialogResult.OK) return;

        var newStudent = new Student
        {
            Id = students.Count + 1,
            Mssv = inputForm.Mssv,
            StudentName = inputForm.StudentName,
            Department = inputForm.Department,
            AvgGrade = inputForm.AvgGrade
        };
        try
        {
            AddStudent(newStudent);
            students.Add(newStudent);
        }
        catch (SqliteException ex)
        {
            if (ex.SqliteErrorCode == 19) // constraint violation
                MessageBox.Show("Mã số sinh viên bị trùng",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show("Database error: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void OnSearchChange(object? sender, EventArgs e)
    {
        if (toolSearchTB.Text == "")
            dataGridView1.DataSource = students;
        else
        {
            var results = students
                .Where(s => 
                    s.StudentName.Contains(toolSearchTB.Text, StringComparison.CurrentCultureIgnoreCase))
                .ToList();
            dataGridView1.DataSource = results;
        }
    }

    private void SaveAndClose(object? sender, EventArgs e)
    {
        foreach (var student in students)
            UpdateStudent(student);
        connection.Close();
    }

    private void TryCreateTable()
    {
        const string sql = """
            CREATE TABLE IF NOT EXISTS Students (
                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                Mssv INTEGER NOT NULL UNIQUE CHECK (Mssv >= 1),
                StudentName TEXT NOT NULL,
                Department TEXT NOT NULL,
                AvgGrade REAL NOT NULL CHECK (AvgGrade >= 0 AND AvgGrade <= 10)
            )
        """;

        using var cmd = new SqliteCommand(sql, connection);
        cmd.ExecuteNonQuery();
    }

    private void LoadStudents()
    {
        const string sql = "SELECT * FROM Students";
        
        using var cmd = new SqliteCommand(sql, connection);
        using var reader = cmd.ExecuteReader();
        
        while (reader.Read())
        {
            students.Add(new Student
            {
                Id = Convert.ToInt32(reader["Id"]),
                Mssv = Convert.ToInt32(reader["Mssv"]),
                StudentName = reader["StudentName"].ToString() ?? "",
                Department = reader["Department"].ToString() ?? "",
                AvgGrade = Convert.ToSingle(reader["AvgGrade"])
            });
        }
    }

    private void UpdateStudent(Student s)
    {
        const string sql = """
             UPDATE Students
             SET Mssv = @mssv, StudentName = @name, Department = @dept, AvgGrade = @grade
             WHERE Id = @id
        """;
        
        using var cmd = new SqliteCommand(sql, connection);
        cmd.Parameters.AddWithValue("@mssv", s.Mssv);
        cmd.Parameters.AddWithValue("@name", s.StudentName);
        cmd.Parameters.AddWithValue("@dept", s.Department);
        cmd.Parameters.AddWithValue("@grade", s.AvgGrade);
        cmd.Parameters.AddWithValue("@id", s.Id);
        
        var rowAffected = cmd.ExecuteNonQuery();
        if (rowAffected == 0)
            AddStudent(s);
    }
    
    private void AddStudent(Student s)
    {
        const string sql = """
            INSERT INTO Students (Mssv, StudentName, Department, AvgGrade)
            VALUES (@mssv, @name, @dept, @grade)
        """;

        using var cmd = new SqliteCommand(sql, connection);
        cmd.Parameters.AddWithValue("@mssv", s.Mssv);
        cmd.Parameters.AddWithValue("@name", s.StudentName);
        cmd.Parameters.AddWithValue("@dept", s.Department);
        cmd.Parameters.AddWithValue("@grade", s.AvgGrade);

        cmd.ExecuteNonQuery();
    }
}

class Student
{
    public int Id { get; set; }
    public int Mssv  { get; set; }
    public string StudentName { get; set; } = "";
    public string Department { get; set; } = "";
    public float AvgGrade { get; set; }
}