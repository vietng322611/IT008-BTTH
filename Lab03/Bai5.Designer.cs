using System.ComponentModel;

namespace Lab03;

partial class Bai5
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
        lb1 = new System.Windows.Forms.Label();
        lb2 = new System.Windows.Forms.Label();
        Num2 = new System.Windows.Forms.TextBox();
        Num1 = new System.Windows.Forms.TextBox();
        label1 = new System.Windows.Forms.Label();
        Answer = new System.Windows.Forms.TextBox();
        AddBtn = new System.Windows.Forms.Button();
        SubBtn = new System.Windows.Forms.Button();
        ProdBtn = new System.Windows.Forms.Button();
        DivBtn = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // lb1
        // 
        lb1.Location = new System.Drawing.Point(117, 65);
        lb1.Name = "lb1";
        lb1.Size = new System.Drawing.Size(90, 27);
        lb1.TabIndex = 0;
        lb1.Text = "Number 1";
        lb1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // lb2
        // 
        lb2.Location = new System.Drawing.Point(117, 114);
        lb2.Name = "lb2";
        lb2.Size = new System.Drawing.Size(90, 27);
        lb2.TabIndex = 1;
        lb2.Text = "Number 2";
        lb2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // Num2
        // 
        Num2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        Num2.Location = new System.Drawing.Point(204, 114);
        Num2.Name = "Num2";
        Num2.Size = new System.Drawing.Size(287, 27);
        Num2.TabIndex = 2;
        // 
        // Num1
        // 
        Num1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        Num1.Location = new System.Drawing.Point(204, 66);
        Num1.Name = "Num1";
        Num1.Size = new System.Drawing.Size(287, 27);
        Num1.TabIndex = 1;
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(117, 283);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(90, 27);
        label1.TabIndex = 11;
        label1.Text = "Answer";
        label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // Answer
        // 
        Answer.BackColor = System.Drawing.SystemColors.Window;
        Answer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        Answer.Location = new System.Drawing.Point(204, 283);
        Answer.Name = "Answer";
        Answer.ReadOnly = true;
        Answer.Size = new System.Drawing.Size(287, 27);
        Answer.TabIndex = 7;
        // 
        // AddBtn
        // 
        AddBtn.Location = new System.Drawing.Point(117, 194);
        AddBtn.Name = "AddBtn";
        AddBtn.Size = new System.Drawing.Size(63, 46);
        AddBtn.TabIndex = 3;
        AddBtn.Text = "+";
        AddBtn.UseVisualStyleBackColor = true;
        // 
        // SubBtn
        // 
        SubBtn.Location = new System.Drawing.Point(204, 194);
        SubBtn.Name = "SubBtn";
        SubBtn.Size = new System.Drawing.Size(63, 46);
        SubBtn.TabIndex = 4;
        SubBtn.Text = "-";
        SubBtn.UseVisualStyleBackColor = true;
        // 
        // ProdBtn
        // 
        ProdBtn.Location = new System.Drawing.Point(291, 194);
        ProdBtn.Name = "ProdBtn";
        ProdBtn.Size = new System.Drawing.Size(63, 46);
        ProdBtn.TabIndex = 5;
        ProdBtn.Text = "X";
        ProdBtn.UseVisualStyleBackColor = true;
        // 
        // DivBtn
        // 
        DivBtn.Location = new System.Drawing.Point(378, 194);
        DivBtn.Name = "DivBtn";
        DivBtn.Size = new System.Drawing.Size(63, 46);
        DivBtn.TabIndex = 6;
        DivBtn.Text = "/";
        DivBtn.UseVisualStyleBackColor = true;
        // 
        // Bai5
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(582, 353);
        Controls.Add(DivBtn);
        Controls.Add(ProdBtn);
        Controls.Add(SubBtn);
        Controls.Add(AddBtn);
        Controls.Add(Answer);
        Controls.Add(label1);
        Controls.Add(Num1);
        Controls.Add(Num2);
        Controls.Add(lb2);
        Controls.Add(lb1);
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "Bai5";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.TextBox Answer;

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.TextBox Num1;

    private System.Windows.Forms.Button SubBtn;
    private System.Windows.Forms.Button ProdBtn;
    private System.Windows.Forms.Button DivBtn;

    private System.Windows.Forms.Button AddBtn;

    private System.Windows.Forms.TextBox Num2;

    private System.Windows.Forms.Label lb2;

    private System.Windows.Forms.Label lb1;

    #endregion
}