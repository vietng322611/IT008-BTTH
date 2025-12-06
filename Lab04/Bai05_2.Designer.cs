using System.ComponentModel;

namespace Lab04;

partial class Bai05_2
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
        label1 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        label3 = new System.Windows.Forms.Label();
        label4 = new System.Windows.Forms.Label();
        mssvTB = new System.Windows.Forms.TextBox();
        nameTB = new System.Windows.Forms.TextBox();
        avgGradeTB = new System.Windows.Forms.TextBox();
        departmentCB = new System.Windows.Forms.ComboBox();
        addBtn = new System.Windows.Forms.Button();
        exitBtn = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label1.Location = new System.Drawing.Point(46, 44);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(130, 25);
        label1.TabIndex = 0;
        label1.Text = "Mã số sinh viên";
        // 
        // label2
        // 
        label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label2.Location = new System.Drawing.Point(46, 82);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(130, 25);
        label2.TabIndex = 0;
        label2.Text = "Tên sinh viên";
        // 
        // label3
        // 
        label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label3.Location = new System.Drawing.Point(46, 120);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(130, 25);
        label3.TabIndex = 0;
        label3.Text = "Khoa";
        // 
        // label4
        // 
        label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label4.Location = new System.Drawing.Point(46, 158);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(130, 25);
        label4.TabIndex = 0;
        label4.Text = "Điểm TB";
        // 
        // mssvTB
        // 
        mssvTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        mssvTB.Location = new System.Drawing.Point(182, 42);
        mssvTB.Name = "mssvTB";
        mssvTB.Size = new System.Drawing.Size(248, 27);
        mssvTB.TabIndex = 1;
        // 
        // nameTB
        // 
        nameTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        nameTB.Location = new System.Drawing.Point(182, 80);
        nameTB.Name = "nameTB";
        nameTB.Size = new System.Drawing.Size(308, 27);
        nameTB.TabIndex = 2;
        // 
        // avgGradeTB
        // 
        avgGradeTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        avgGradeTB.Location = new System.Drawing.Point(182, 156);
        avgGradeTB.Name = "avgGradeTB";
        avgGradeTB.Size = new System.Drawing.Size(124, 27);
        avgGradeTB.TabIndex = 4;
        // 
        // departmentCB
        // 
        departmentCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        departmentCB.FormattingEnabled = true;
        departmentCB.Items.AddRange(new object[] { "Công nghệ thông tin", "Hệ thống thông tin", "Kỹ thuật phần mềm" });
        departmentCB.Location = new System.Drawing.Point(182, 119);
        departmentCB.Name = "departmentCB";
        departmentCB.Size = new System.Drawing.Size(306, 28);
        departmentCB.TabIndex = 3;
        // 
        // addBtn
        // 
        addBtn.BackColor = System.Drawing.Color.LimeGreen;
        addBtn.Location = new System.Drawing.Point(304, 206);
        addBtn.Name = "addBtn";
        addBtn.Size = new System.Drawing.Size(104, 32);
        addBtn.TabIndex = 5;
        addBtn.Text = "Thêm mới";
        addBtn.UseVisualStyleBackColor = false;
        // 
        // exitBtn
        // 
        exitBtn.BackColor = System.Drawing.Color.DarkOrange;
        exitBtn.Location = new System.Drawing.Point(414, 206);
        exitBtn.Name = "exitBtn";
        exitBtn.Size = new System.Drawing.Size(74, 32);
        exitBtn.TabIndex = 6;
        exitBtn.Text = "Thoát";
        exitBtn.UseVisualStyleBackColor = false;
        // 
        // Bai05_2
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(502, 250);
        Controls.Add(exitBtn);
        Controls.Add(addBtn);
        Controls.Add(departmentCB);
        Controls.Add(avgGradeTB);
        Controls.Add(nameTB);
        Controls.Add(mssvTB);
        Controls.Add(label4);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(label1);
        StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        Text = "Bai05_2";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Button exitBtn;

    private System.Windows.Forms.Button addBtn;

    private System.Windows.Forms.ComboBox departmentCB;

    private System.Windows.Forms.TextBox avgGradeTB;

    private System.Windows.Forms.TextBox nameTB;

    private System.Windows.Forms.TextBox mssvTB;

    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;

    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.Label label1;

    #endregion
}