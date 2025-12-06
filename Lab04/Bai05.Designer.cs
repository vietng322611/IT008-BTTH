using System.ComponentModel;

namespace Lab04;

partial class Bai05
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bai05));
        menuStrip1 = new System.Windows.Forms.MenuStrip();
        fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        menuNewBtn = new System.Windows.Forms.ToolStripMenuItem();
        menuExitBtn = new System.Windows.Forms.ToolStripMenuItem();
        toolStrip1 = new System.Windows.Forms.ToolStrip();
        toolNewBtn = new System.Windows.Forms.ToolStripButton();
        toolStripLabel = new System.Windows.Forms.ToolStripLabel();
        toolSearchTB = new System.Windows.Forms.ToolStripTextBox();
        dataGridView1 = new System.Windows.Forms.DataGridView();
        SttCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
        MssvCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
        StudentNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
        DepartmentCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
        AvgGradeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
        menuStrip1.SuspendLayout();
        toolStrip1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
        SuspendLayout();
        // 
        // menuStrip1
        // 
        menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
        menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
        menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { fileToolStripMenuItem });
        menuStrip1.Location = new System.Drawing.Point(0, 0);
        menuStrip1.Name = "menuStrip1";
        menuStrip1.Size = new System.Drawing.Size(685, 28);
        menuStrip1.TabIndex = 0;
        menuStrip1.Text = "menuStrip1";
        // 
        // fileToolStripMenuItem
        // 
        fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { menuNewBtn, menuExitBtn });
        fileToolStripMenuItem.Name = "fileToolStripMenuItem";
        fileToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
        fileToolStripMenuItem.Text = "Chức năng";
        // 
        // menuNewBtn
        // 
        menuNewBtn.Image = ((System.Drawing.Image)resources.GetObject("menuNewBtn.Image"));
        menuNewBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
        menuNewBtn.Name = "menuNewBtn";
        menuNewBtn.ShortcutKeys = ((System.Windows.Forms.Keys)(System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N));
        menuNewBtn.Size = new System.Drawing.Size(212, 26);
        menuNewBtn.Text = "Thêm mới";
        // 
        // menuExitBtn
        // 
        menuExitBtn.Name = "menuExitBtn";
        menuExitBtn.Size = new System.Drawing.Size(212, 26);
        menuExitBtn.Text = "Thoát";
        // 
        // toolStrip1
        // 
        toolStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
        toolStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
        toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { toolNewBtn, toolStripLabel, toolSearchTB });
        toolStrip1.Location = new System.Drawing.Point(0, 28);
        toolStrip1.Name = "toolStrip1";
        toolStrip1.Size = new System.Drawing.Size(685, 47);
        toolStrip1.TabIndex = 1;
        toolStrip1.Text = "toolStrip1";
        // 
        // toolNewBtn
        // 
        toolNewBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        toolNewBtn.Image = ((System.Drawing.Image)resources.GetObject("toolNewBtn.Image"));
        toolNewBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
        toolNewBtn.Name = "toolNewBtn";
        toolNewBtn.Size = new System.Drawing.Size(149, 44);
        toolNewBtn.Text = "Thêm Mới";
        // 
        // toolStripLabel
        // 
        toolStripLabel.Margin = new System.Windows.Forms.Padding(90, 1, 0, 2);
        toolStripLabel.Name = "toolStripLabel";
        toolStripLabel.Size = new System.Drawing.Size(129, 44);
        toolStripLabel.Text = "Tìm kiếm theo tên";
        toolStripLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // toolSearchTB
        // 
        toolSearchTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
        toolSearchTB.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        toolSearchTB.Name = "toolSearchTB";
        toolSearchTB.Size = new System.Drawing.Size(300, 47);
        // 
        // dataGridView1
        // 
        dataGridView1.AllowUserToAddRows = false;
        dataGridView1.ColumnHeadersHeight = 29;
        dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { SttCol, MssvCol, StudentNameCol, DepartmentCol, AvgGradeCol });
        dataGridView1.Location = new System.Drawing.Point(0, 78);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.RowHeadersWidth = 51;
        dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
        dataGridView1.Size = new System.Drawing.Size(685, 371);
        dataGridView1.TabIndex = 2;
        // 
        // SttCol
        // 
        SttCol.DataPropertyName = "Id";
        SttCol.HeaderText = "Số TT";
        SttCol.MinimumWidth = 6;
        SttCol.Name = "SttCol";
        SttCol.Width = 110;
        // 
        // MssvCol
        // 
        MssvCol.DataPropertyName = "Mssv";
        MssvCol.HeaderText = "Mã Số SV";
        MssvCol.MinimumWidth = 6;
        MssvCol.Name = "MssvCol";
        MssvCol.Width = 110;
        // 
        // StudentNameCol
        // 
        StudentNameCol.DataPropertyName = "StudentName";
        StudentNameCol.HeaderText = "Tên sinh viên";
        StudentNameCol.MinimumWidth = 6;
        StudentNameCol.Name = "StudentNameCol";
        StudentNameCol.Width = 140;
        // 
        // DepartmentCol
        // 
        DepartmentCol.DataPropertyName = "Department";
        DepartmentCol.HeaderText = "Khoa";
        DepartmentCol.MinimumWidth = 6;
        DepartmentCol.Name = "DepartmentCol";
        DepartmentCol.Width = 160;
        // 
        // AvgGradeCol
        // 
        AvgGradeCol.DataPropertyName = "AvgGrade";
        AvgGradeCol.HeaderText = "Điểm TB";
        AvgGradeCol.MinimumWidth = 6;
        AvgGradeCol.Name = "AvgGradeCol";
        AvgGradeCol.Width = 110;
        // 
        // Bai05
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(685, 450);
        Controls.Add(dataGridView1);
        Controls.Add(toolStrip1);
        Controls.Add(menuStrip1);
        MainMenuStrip = menuStrip1;
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "Bai05";
        menuStrip1.ResumeLayout(false);
        menuStrip1.PerformLayout();
        toolStrip1.ResumeLayout(false);
        toolStrip1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.DataGridViewTextBoxColumn SttCol;
    private System.Windows.Forms.DataGridViewTextBoxColumn MssvCol;
    private System.Windows.Forms.DataGridViewTextBoxColumn StudentNameCol;
    private System.Windows.Forms.DataGridViewTextBoxColumn DepartmentCol;
    private System.Windows.Forms.DataGridViewTextBoxColumn AvgGradeCol;

    private MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStrip toolStrip1;
    private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem menuNewBtn;
    private ToolStripMenuItem menuExitBtn;
    private System.Windows.Forms.ToolStripButton toolNewBtn;
    private System.Windows.Forms.ToolStripTextBox toolSearchTB;
    private System.Windows.Forms.ToolStripLabel toolStripLabel;

    #endregion
}