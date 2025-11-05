using System.ComponentModel;

namespace Lab03;

partial class Bai4
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
        toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
        menuStrip1 = new System.Windows.Forms.MenuStrip();
        formatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        chooseColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
        toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
        menuStrip1.SuspendLayout();
        SuspendLayout();
        // 
        // toolStripMenuItem1
        // 
        toolStripMenuItem1.Name = "toolStripMenuItem1";
        toolStripMenuItem1.Size = new System.Drawing.Size(32, 19);
        // 
        // menuStrip1
        // 
        menuStrip1.BackColor = System.Drawing.SystemColors.Window;
        menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
        menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { formatToolStripMenuItem });
        menuStrip1.Location = new System.Drawing.Point(0, 0);
        menuStrip1.Name = "menuStrip1";
        menuStrip1.Size = new System.Drawing.Size(782, 28);
        menuStrip1.TabIndex = 0;
        menuStrip1.Text = "menuStrip1";
        // 
        // formatToolStripMenuItem
        // 
        formatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { chooseColorToolStripMenuItem });
        formatToolStripMenuItem.Name = "formatToolStripMenuItem";
        formatToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
        formatToolStripMenuItem.Text = "Format";
        // 
        // chooseColorToolStripMenuItem
        // 
        chooseColorToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
        chooseColorToolStripMenuItem.Name = "chooseColorToolStripMenuItem";
        chooseColorToolStripMenuItem.ShowShortcutKeys = false;
        chooseColorToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
        chooseColorToolStripMenuItem.Text = "Choose Color";
        chooseColorToolStripMenuItem.Click += ChooseColorClick;
        // 
        // toolStripMenuItem2
        // 
        toolStripMenuItem2.Name = "toolStripMenuItem2";
        toolStripMenuItem2.Size = new System.Drawing.Size(32, 19);
        // 
        // toolStripMenuItem3
        // 
        toolStripMenuItem3.Name = "toolStripMenuItem3";
        toolStripMenuItem3.Size = new System.Drawing.Size(32, 19);
        // 
        // Bai4
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.SystemColors.Control;
        ClientSize = new System.Drawing.Size(782, 453);
        Controls.Add(menuStrip1);
        MainMenuStrip = menuStrip1;
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "Bai4";
        menuStrip1.ResumeLayout(false);
        menuStrip1.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;

    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;

    private System.Windows.Forms.ToolStripMenuItem formatToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem chooseColorToolStripMenuItem;

    private System.Windows.Forms.MenuStrip menuStrip1;

    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;

    #endregion
}