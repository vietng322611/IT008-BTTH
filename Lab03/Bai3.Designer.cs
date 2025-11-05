using System.ComponentModel;

namespace Lab03;

partial class Bai3
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
        ChangeColorBtn = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // ChangeColorBtn
        // 
        ChangeColorBtn.Location = new System.Drawing.Point(325, 187);
        ChangeColorBtn.Name = "ChangeColorBtn";
        ChangeColorBtn.Size = new System.Drawing.Size(140, 60);
        ChangeColorBtn.TabIndex = 0;
        ChangeColorBtn.Text = "Change Color";
        ChangeColorBtn.UseVisualStyleBackColor = true;
        // 
        // Bai3
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(782, 453);
        Controls.Add(ChangeColorBtn);
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "Bai3";
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button ChangeColorBtn;

    #endregion
}