using System;
using System.Windows.Forms;

namespace Lab03;

public partial class Bai9 : Form
{
    public Bai9()
    {
        InitializeComponent();

        ChooseBtn.Click += ChooseOnClick;
        RemoveBtn.Click += RemoveOnClick;
        
        SaveBtn.Click += SaveOnClick;
        CancelBtn.Click += CancelOnClick;
    }

    private void ChooseOnClick(object? sender, EventArgs e)
    {
        var subject = SubjectList.SelectedItem;
        if (subject == null) return;
        
        SubjectList.Items.Remove(subject);
        SubjectChoose.Items.Add(subject);
    }

    private void RemoveOnClick(object? sender, EventArgs e)
    {
        var subject = SubjectChoose.SelectedItem;
        if (subject == null) return;
        
        SubjectChoose.Items.Remove(subject);
        SubjectList.Items.Add(subject);
    }

    private void SaveOnClick(object? sender, EventArgs e)
    {
        if (!CheckFields()) return;

        foreach (var row in StudentData.Rows)
        {
            if (row is not DataGridViewRow dataGridViewRow) continue;
            if ((string)dataGridViewRow.Cells[0].Value != StudentId.Text) continue;
            
            dataGridViewRow.Cells[1].Value = StudentName.Text;
            dataGridViewRow.Cells[2].Value = StudentMajor.Text;
            dataGridViewRow.Cells[3].Value = MaleCB.Checked ? "Nam" : "Nữ";
            dataGridViewRow.Cells[4].Value = SubjectChoose.Items.Count;
            return;
        }

        StudentData.Rows.Add(
            StudentId.Text,
            StudentName.Text,
            StudentMajor.Text,
            MaleCB.Checked ? "Nam" : "Nữ",
            SubjectChoose.Items.Count
            );
        
        ClearFields();
    }

    private void CancelOnClick(object? sender, EventArgs e)
    {
        ClearFields();
    }

    private bool CheckFields()
    {
        if (StudentId.Text.Trim() == "")
        {
            MessageBox.Show(
                @"Mã sinh viên không hợp lệ", 
                @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        if (StudentName.Text.Trim() == "")
        {
            MessageBox.Show(
                @"Tên sinh viên không hợp lệ", 
                @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        if (StudentMajor.Text.Trim() == "")
        {
            MessageBox.Show(
                @"Chuyên ngành không hợp lệ", 
                @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
        
        if (MaleCB.Checked == FemaleCB.Checked)
        {
            MessageBox.Show(
                @"Giới tính không hợp lệ", 
                @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        if (SubjectChoose.Items.Count == 0)
        {
            MessageBox.Show(
                @"Số môn học không hợp lệ", 
                @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        return true;
    }

    private void ClearFields()
    {
        StudentId.Text = "";
        StudentName.Text = "";
        StudentMajor.Text = "";
        MaleCB.Checked = FemaleCB.Checked = false;
        SubjectChoose.Items.Clear();
        SubjectList.Items.Clear();
        SubjectList.Items.AddRange([
            "Cơ sở dữ liệu",
            "Cơ sở DL NC",
            "PTTK Hệ thống thông tin"
        ]);
    }
}