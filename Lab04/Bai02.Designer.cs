using System.ComponentModel;

namespace Lab04;

partial class Bai02
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
        TimeLabel = new System.Windows.Forms.Label();
        SuspendLayout();
        // 
        // TimeLabel
        // 
        TimeLabel.Location = new System.Drawing.Point(12, 9);
        TimeLabel.Name = "TimeLabel";
        TimeLabel.Size = new System.Drawing.Size(414, 432);
        TimeLabel.TabIndex = 0;
        TimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // Bai02
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(438, 450);
        Controls.Add(TimeLabel);
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "Simple Clock";
        ResumeLayout(false);
    }

    private System.Windows.Forms.Label TimeLabel;

    #endregion
}