using System.ComponentModel;

namespace Lab03;

partial class Bai9
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        IdCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
        NameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
        MajorCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
        GenderCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
        SubjectCountCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
        groupBox1 = new System.Windows.Forms.GroupBox();
        CancelBtn = new System.Windows.Forms.Button();
        SaveBtn = new System.Windows.Forms.Button();
        SubjectChoose = new System.Windows.Forms.ListBox();
        RemoveBtn = new System.Windows.Forms.Button();
        label5 = new System.Windows.Forms.Label();
        FemaleCB = new System.Windows.Forms.CheckBox();
        label4 = new System.Windows.Forms.Label();
        StudentMajor = new System.Windows.Forms.ComboBox();
        label3 = new System.Windows.Forms.Label();
        StudentName = new System.Windows.Forms.TextBox();
        label2 = new System.Windows.Forms.Label();
        ChooseBtn = new System.Windows.Forms.Button();
        SubjectList = new System.Windows.Forms.ListBox();
        MaleCB = new System.Windows.Forms.CheckBox();
        StudentId = new System.Windows.Forms.TextBox();
        label1 = new System.Windows.Forms.Label();
        StudentData = new System.Windows.Forms.DataGridView();
        groupBox1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)StudentData).BeginInit();
        SuspendLayout();
        // 
        // IdCol
        // 
        IdCol.HeaderText = "MSSV";
        IdCol.MinimumWidth = 6;
        IdCol.Name = "IdCol";
        IdCol.Width = 130;
        // 
        // NameCol
        // 
        NameCol.HeaderText = "Họ tên";
        NameCol.MinimumWidth = 6;
        NameCol.Name = "NameCol";
        NameCol.Width = 230;
        // 
        // MajorCol
        // 
        MajorCol.HeaderText = "Chuyên ngành";
        MajorCol.MinimumWidth = 6;
        MajorCol.Name = "MajorCol";
        MajorCol.Width = 230;
        // 
        // GenderCol
        // 
        GenderCol.HeaderText = "Giới tính";
        GenderCol.MinimumWidth = 6;
        GenderCol.Name = "GenderCol";
        GenderCol.Width = 140;
        // 
        // SubjectCountCol
        // 
        SubjectCountCol.HeaderText = "Số môn";
        SubjectCountCol.MinimumWidth = 6;
        SubjectCountCol.Name = "SubjectCountCol";
        SubjectCountCol.Width = 84;
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(CancelBtn);
        groupBox1.Controls.Add(SaveBtn);
        groupBox1.Controls.Add(SubjectChoose);
        groupBox1.Controls.Add(RemoveBtn);
        groupBox1.Controls.Add(label5);
        groupBox1.Controls.Add(FemaleCB);
        groupBox1.Controls.Add(label4);
        groupBox1.Controls.Add(StudentMajor);
        groupBox1.Controls.Add(label3);
        groupBox1.Controls.Add(StudentName);
        groupBox1.Controls.Add(label2);
        groupBox1.Controls.Add(ChooseBtn);
        groupBox1.Controls.Add(SubjectList);
        groupBox1.Controls.Add(MaleCB);
        groupBox1.Controls.Add(StudentId);
        groupBox1.Controls.Add(label1);
        groupBox1.Location = new System.Drawing.Point(35, 12);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new System.Drawing.Size(867, 408);
        groupBox1.TabIndex = 0;
        groupBox1.TabStop = false;
        groupBox1.Text = "Thông tin sinh viên";
        // 
        // CancelBtn
        // 
        CancelBtn.Location = new System.Drawing.Point(448, 363);
        CancelBtn.Name = "CancelBtn";
        CancelBtn.Size = new System.Drawing.Size(93, 33);
        CancelBtn.TabIndex = 7;
        CancelBtn.Text = "Xóa chọn";
        CancelBtn.UseVisualStyleBackColor = true;
        // 
        // SaveBtn
        // 
        SaveBtn.Location = new System.Drawing.Point(320, 363);
        SaveBtn.Name = "SaveBtn";
        SaveBtn.Size = new System.Drawing.Size(109, 33);
        SaveBtn.TabIndex = 6;
        SaveBtn.Text = "Lưu thông tin";
        SaveBtn.UseVisualStyleBackColor = true;
        // 
        // SubjectChoose
        // 
        SubjectChoose.FormattingEnabled = true;
        SubjectChoose.Location = new System.Drawing.Point(538, 262);
        SubjectChoose.Name = "SubjectChoose";
        SubjectChoose.Size = new System.Drawing.Size(288, 84);
        SubjectChoose.TabIndex = 0;
        SubjectChoose.TabStop = false;
        // 
        // RemoveBtn
        // 
        RemoveBtn.Location = new System.Drawing.Point(483, 306);
        RemoveBtn.Name = "RemoveBtn";
        RemoveBtn.Size = new System.Drawing.Size(34, 33);
        RemoveBtn.TabIndex = 0;
        RemoveBtn.TabStop = false;
        RemoveBtn.Text = "<";
        RemoveBtn.UseVisualStyleBackColor = true;
        // 
        // label5
        // 
        label5.Location = new System.Drawing.Point(181, 211);
        label5.Name = "label5";
        label5.Size = new System.Drawing.Size(200, 28);
        label5.TabIndex = 17;
        label5.Text = "Chọn các môn học tham gia";
        label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // FemaleCB
        // 
        FemaleCB.Location = new System.Drawing.Point(394, 159);
        FemaleCB.Name = "FemaleCB";
        FemaleCB.Size = new System.Drawing.Size(70, 35);
        FemaleCB.TabIndex = 5;
        FemaleCB.Text = "Nữ";
        FemaleCB.UseVisualStyleBackColor = true;
        // 
        // label4
        // 
        label4.Location = new System.Drawing.Point(181, 159);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(124, 28);
        label4.TabIndex = 13;
        label4.Text = "Giới tính";
        label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // StudentMajor
        // 
        StudentMajor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        StudentMajor.FormattingEnabled = true;
        StudentMajor.Items.AddRange(new object[] { "Hệ thống thông tin", "Công nghệ phần mềm" });
        StudentMajor.Location = new System.Drawing.Point(311, 114);
        StudentMajor.Name = "StudentMajor";
        StudentMajor.Size = new System.Drawing.Size(256, 28);
        StudentMajor.TabIndex = 3;
        // 
        // label3
        // 
        label3.Location = new System.Drawing.Point(181, 113);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(124, 28);
        label3.TabIndex = 9;
        label3.Text = "Chuyên ngành";
        label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // StudentName
        // 
        StudentName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        StudentName.Location = new System.Drawing.Point(311, 69);
        StudentName.Name = "StudentName";
        StudentName.Size = new System.Drawing.Size(256, 27);
        StudentName.TabIndex = 2;
        // 
        // label2
        // 
        label2.Location = new System.Drawing.Point(181, 69);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(124, 28);
        label2.TabIndex = 5;
        label2.Text = "Họ tên";
        label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // ChooseBtn
        // 
        ChooseBtn.Location = new System.Drawing.Point(483, 267);
        ChooseBtn.Name = "ChooseBtn";
        ChooseBtn.Size = new System.Drawing.Size(34, 33);
        ChooseBtn.TabIndex = 0;
        ChooseBtn.TabStop = false;
        ChooseBtn.Text = ">";
        ChooseBtn.UseVisualStyleBackColor = true;
        // 
        // SubjectList
        // 
        SubjectList.FormattingEnabled = true;
        SubjectList.Items.AddRange(new object[] { "Cơ sở dữ liệu", "Cơ sở DL NC", "PTTK Hệ thống thông tin" });
        SubjectList.Location = new System.Drawing.Point(181, 262);
        SubjectList.Name = "SubjectList";
        SubjectList.Size = new System.Drawing.Size(288, 84);
        SubjectList.TabIndex = 0;
        SubjectList.TabStop = false;
        // 
        // MaleCB
        // 
        MaleCB.Location = new System.Drawing.Point(311, 159);
        MaleCB.Name = "MaleCB";
        MaleCB.Size = new System.Drawing.Size(70, 35);
        MaleCB.TabIndex = 4;
        MaleCB.Text = "Nam";
        MaleCB.UseVisualStyleBackColor = true;
        // 
        // StudentId
        // 
        StudentId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        StudentId.Location = new System.Drawing.Point(311, 26);
        StudentId.Name = "StudentId";
        StudentId.Size = new System.Drawing.Size(133, 27);
        StudentId.TabIndex = 1;
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(181, 26);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(124, 28);
        label1.TabIndex = 0;
        label1.Text = "Mã sinh viên";
        label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // StudentData
        // 
        StudentData.ColumnHeadersHeight = 29;
        StudentData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { IdCol, NameCol, MajorCol, GenderCol, SubjectCountCol });
        StudentData.Location = new System.Drawing.Point(44, 436);
        StudentData.Name = "StudentData";
        StudentData.RowHeadersWidth = 51;
        StudentData.Size = new System.Drawing.Size(867, 306);
        StudentData.TabIndex = 1;
        StudentData.TabStop = false;
        // 
        // Bai9
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(945, 754);
        Controls.Add(StudentData);
        Controls.Add(groupBox1);
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "Bai9";
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)StudentData).EndInit();
        ResumeLayout(false);
    }

    private System.Windows.Forms.DataGridView StudentData;

    private System.Windows.Forms.DataGridViewTextBoxColumn IdCol;
    private System.Windows.Forms.DataGridViewTextBoxColumn NameCol;
    private System.Windows.Forms.DataGridViewTextBoxColumn MajorCol;
    private System.Windows.Forms.DataGridViewTextBoxColumn GenderCol;
    private System.Windows.Forms.DataGridViewTextBoxColumn SubjectCountCol;

    private System.Windows.Forms.Button CancelBtn;

    private System.Windows.Forms.Button SaveBtn;

    private System.Windows.Forms.ListBox SubjectChoose;

    private System.Windows.Forms.Button RemoveBtn;

    private System.Windows.Forms.Label label5;

    private System.Windows.Forms.CheckBox FemaleCB;

    private System.Windows.Forms.Label label4;

    private System.Windows.Forms.ComboBox StudentMajor;

    private System.Windows.Forms.Label label3;

    private System.Windows.Forms.TextBox StudentName;
    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.Button ChooseBtn;

    private System.Windows.Forms.ListBox SubjectList;

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox StudentId;
    private System.Windows.Forms.CheckBox MaleCB;

    private System.Windows.Forms.GroupBox groupBox1;

    #endregion
}