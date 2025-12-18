using System.ComponentModel;

namespace Lab05;

partial class Bai06
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
        listBox = new System.Windows.Forms.ListBox();
        SuspendLayout();
        // 
        // listBox
        // 
        listBox.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        listBox.FormattingEnabled = true;
        listBox.HorizontalExtent = 362;
        listBox.HorizontalScrollbar = true;
        listBox.ItemHeight = 37;
        listBox.Location = new System.Drawing.Point(29, 27);
        listBox.Name = "listBox";
        listBox.Size = new System.Drawing.Size(362, 448);
        listBox.TabIndex = 0;
        // 
        // Bai06
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(415, 492);
        Controls.Add(listBox);
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "All Fonts";
        ResumeLayout(false);
    }

    private System.Windows.Forms.ListBox listBox;

    #endregion
}