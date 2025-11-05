using System.ComponentModel;

namespace Lab03;

partial class Bai2
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
        PaintBtn = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // PaintBtn
        // 
        PaintBtn.Location = new System.Drawing.Point(335, 164);
        PaintBtn.Name = "PaintBtn";
        PaintBtn.Size = new System.Drawing.Size(132, 52);
        PaintBtn.TabIndex = 1;
        PaintBtn.Text = "Reset paint";
        PaintBtn.UseVisualStyleBackColor = true;
        // 
        // Bai2
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(782, 453);
        Controls.Add(PaintBtn);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "Bai2";
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button PaintBtn;

    #endregion
}