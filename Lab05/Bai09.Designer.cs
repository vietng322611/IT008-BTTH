using System.ComponentModel;

namespace Lab05;

partial class Bai09
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
        ShapeCB = new System.Windows.Forms.ComboBox();
        SuspendLayout();
        // 
        // ShapeCB
        // 
        ShapeCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        ShapeCB.FormattingEnabled = true;
        ShapeCB.Items.AddRange(new object[] { "Circle", "Square", "Ellipse", "Pie", "Filled Circle", "Filled Square", "Filled Ellipse", "Filled Pie" });
        ShapeCB.Location = new System.Drawing.Point(12, 12);
        ShapeCB.Name = "ShapeCB";
        ShapeCB.Size = new System.Drawing.Size(156, 28);
        ShapeCB.TabIndex = 0;
        // 
        // Bai09
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(382, 353);
        Controls.Add(ShapeCB);
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "Bai09";
        ResumeLayout(false);
    }

    private System.Windows.Forms.ComboBox ShapeCB;

    #endregion
}