using System;
using System.Windows.Forms;

namespace Lab04;

public partial class Bai05_2 : Form
{
    public int Mssv;
    public string StudentName;
    public string Department;
    public float AvgGrade;
    
    public Bai05_2()
    {
        InitializeComponent();

        departmentCB.SelectedItem = "Công nghệ thông tin";
        
        addBtn.Click += AddNew;
        exitBtn.Click += (_, _) =>
        {
            DialogResult = DialogResult.Cancel;
            Close();
        };
    }

    private void AddNew(object? sender, EventArgs e)
    {
        if (!int.TryParse(mssvTB.Text, out Mssv) || Mssv <= 0)
        {
            MessageBox.Show("Mã số sinh viên không hợp lệ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        if (string.IsNullOrEmpty(nameTB.Text))
        {
            MessageBox.Show("Tên không được để trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        if (!float.TryParse(avgGradeTB.Text, out AvgGrade) ||
            AvgGrade < 0 || AvgGrade > 10)
        {
            MessageBox.Show("Điểm trung bình không hợp lệ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        StudentName = nameTB.Text;
        Department = departmentCB.Text;
        DialogResult = DialogResult.OK;
        Close();
    }
}