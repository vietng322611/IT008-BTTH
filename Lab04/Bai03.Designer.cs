using System.ComponentModel;

namespace Lab04;

partial class Bai03
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bai03));
        statusStrip = new System.Windows.Forms.StatusStrip();
        menuStrip = new System.Windows.Forms.MenuStrip();
        fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        openFileDialog = new System.Windows.Forms.OpenFileDialog();
        menuStrip.SuspendLayout();
        SuspendLayout();
        // 
        // statusStrip
        // 
        statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
        statusStrip.Location = new System.Drawing.Point(0, 428);
        statusStrip.Name = "statusStrip";
        statusStrip.Size = new System.Drawing.Size(800, 22);
        statusStrip.TabIndex = 0;
        statusStrip.Text = "238472359232";
        // 
        // menuStrip
        // 
        menuStrip.BackColor = System.Drawing.SystemColors.Control;
        menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
        menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { fileToolStripMenuItem });
        menuStrip.Location = new System.Drawing.Point(0, 0);
        menuStrip.Name = "menuStrip";
        menuStrip.Size = new System.Drawing.Size(800, 28);
        menuStrip.TabIndex = 1;
        menuStrip.Text = "menuStrip";
        // 
        // fileToolStripMenuItem
        // 
        fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { openToolStripMenuItem, exitToolStripMenuItem });
        fileToolStripMenuItem.Name = "fileToolStripMenuItem";
        fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
        fileToolStripMenuItem.Text = "File";
        // 
        // openToolStripMenuItem
        // 
        openToolStripMenuItem.Image = ((System.Drawing.Image)resources.GetObject("openToolStripMenuItem.Image"));
        openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
        openToolStripMenuItem.Name = "openToolStripMenuItem";
        openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O));
        openToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
        openToolStripMenuItem.Text = "&Open";
        // 
        // exitToolStripMenuItem
        // 
        exitToolStripMenuItem.Name = "exitToolStripMenuItem";
        exitToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
        exitToolStripMenuItem.Text = "E&xit";
        // 
        // openFileDialog
        // 
        openFileDialog.DefaultExt = "mp4";
        openFileDialog.Filter = "Media files|*.mp4;*.avi;*.mpeg;*.wav;*.midi;*.mp3";
        // 
        // Bai03
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(statusStrip);
        Controls.Add(menuStrip);
        MainMenuStrip = menuStrip;
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "Chương trình Windows Media";
        menuStrip.ResumeLayout(false);
        menuStrip.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.OpenFileDialog openFileDialog;

    private StatusStrip statusStrip;
    private MenuStrip menuStrip;
    private ToolStripMenuItem fileToolStripMenuItem;
    private ToolStripMenuItem openToolStripMenuItem;
    private ToolStripMenuItem exitToolStripMenuItem;

    #endregion
}