using System.ComponentModel;
using Microsoft.VisualBasic.CompilerServices;

namespace Lab04;

partial class Bai04
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bai04));
        menuStrip = new System.Windows.Forms.MenuStrip();
        fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
        saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        formatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        toolStrip = new System.Windows.Forms.ToolStrip();
        newToolStripButton = new System.Windows.Forms.ToolStripButton();
        saveToolStripButton = new System.Windows.Forms.ToolStripButton();
        toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
        fontToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
        fontSizeToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
        boldToolStripButton = new System.Windows.Forms.ToolStripButton();
        italicToolStripButton = new System.Windows.Forms.ToolStripButton();
        underlineToolStripButton = new System.Windows.Forms.ToolStripButton();
        toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
        richTextBox = new System.Windows.Forms.RichTextBox();
        fontDialog = new System.Windows.Forms.FontDialog();
        openFileDialog = new System.Windows.Forms.OpenFileDialog();
        saveFileDialog = new System.Windows.Forms.SaveFileDialog();
        menuStrip.SuspendLayout();
        toolStrip.SuspendLayout();
        SuspendLayout();
        // 
        // menuStrip
        // 
        menuStrip.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
        menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
        menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { fileToolStripMenuItem, formatToolStripMenuItem });
        menuStrip.Location = new System.Drawing.Point(0, 0);
        menuStrip.Name = "menuStrip";
        menuStrip.Size = new System.Drawing.Size(589, 28);
        menuStrip.TabIndex = 0;
        menuStrip.Text = "menuStrip1";
        // 
        // fileToolStripMenuItem
        // 
        fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { newToolStripMenuItem, openToolStripMenuItem, toolStripSeparator, saveToolStripMenuItem, exitToolStripMenuItem });
        fileToolStripMenuItem.Name = "fileToolStripMenuItem";
        fileToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
        fileToolStripMenuItem.Text = "Hệ thống";
        // 
        // newToolStripMenuItem
        // 
        newToolStripMenuItem.Image = ((System.Drawing.Image)resources.GetObject("newToolStripMenuItem.Image"));
        newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
        newToolStripMenuItem.Name = "newToolStripMenuItem";
        newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N));
        newToolStripMenuItem.Size = new System.Drawing.Size(285, 26);
        newToolStripMenuItem.Text = "Tạo văn bản mới";
        // 
        // openToolStripMenuItem
        // 
        openToolStripMenuItem.Image = ((System.Drawing.Image)resources.GetObject("openToolStripMenuItem.Image"));
        openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
        openToolStripMenuItem.Name = "openToolStripMenuItem";
        openToolStripMenuItem.Size = new System.Drawing.Size(285, 26);
        openToolStripMenuItem.Text = "Mở tập tin";
        // 
        // toolStripSeparator
        // 
        toolStripSeparator.Name = "toolStripSeparator";
        toolStripSeparator.Size = new System.Drawing.Size(282, 6);
        // 
        // saveToolStripMenuItem
        // 
        saveToolStripMenuItem.Image = ((System.Drawing.Image)resources.GetObject("saveToolStripMenuItem.Image"));
        saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
        saveToolStripMenuItem.Name = "saveToolStripMenuItem";
        saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S));
        saveToolStripMenuItem.Size = new System.Drawing.Size(285, 26);
        saveToolStripMenuItem.Text = "Lưu nội dung văn bản";
        // 
        // exitToolStripMenuItem
        // 
        exitToolStripMenuItem.Name = "exitToolStripMenuItem";
        exitToolStripMenuItem.Size = new System.Drawing.Size(285, 26);
        exitToolStripMenuItem.Text = "Thoát";
        // 
        // formatToolStripMenuItem
        // 
        formatToolStripMenuItem.Name = "formatToolStripMenuItem";
        formatToolStripMenuItem.Size = new System.Drawing.Size(92, 24);
        formatToolStripMenuItem.Text = "Định dạng";
        // 
        // toolStrip
        // 
        toolStrip.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
        toolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
        toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { newToolStripButton, saveToolStripButton, toolStripSeparator5, fontToolStripComboBox, fontSizeToolStripComboBox, boldToolStripButton, italicToolStripButton, underlineToolStripButton, toolStripSeparator6 });
        toolStrip.Location = new System.Drawing.Point(0, 28);
        toolStrip.Name = "toolStrip";
        toolStrip.Size = new System.Drawing.Size(589, 38);
        toolStrip.TabIndex = 1;
        toolStrip.Text = "toolStrip1";
        // 
        // newToolStripButton
        // 
        newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
        newToolStripButton.Image = ((System.Drawing.Image)resources.GetObject("newToolStripButton.Image"));
        newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
        newToolStripButton.Name = "newToolStripButton";
        newToolStripButton.Padding = new System.Windows.Forms.Padding(5);
        newToolStripButton.Size = new System.Drawing.Size(34, 35);
        newToolStripButton.Text = "&New";
        // 
        // saveToolStripButton
        // 
        saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
        saveToolStripButton.Image = ((System.Drawing.Image)resources.GetObject("saveToolStripButton.Image"));
        saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
        saveToolStripButton.Name = "saveToolStripButton";
        saveToolStripButton.Padding = new System.Windows.Forms.Padding(5);
        saveToolStripButton.Size = new System.Drawing.Size(34, 35);
        saveToolStripButton.Text = "&Save";
        // 
        // toolStripSeparator5
        // 
        toolStripSeparator5.Name = "toolStripSeparator5";
        toolStripSeparator5.Size = new System.Drawing.Size(6, 38);
        // 
        // fontToolStripComboBox
        // 
        fontToolStripComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
        fontToolStripComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
        fontToolStripComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        fontToolStripComboBox.Name = "fontToolStripComboBox";
        fontToolStripComboBox.Padding = new System.Windows.Forms.Padding(5);
        fontToolStripComboBox.Size = new System.Drawing.Size(150, 38);
        // 
        // fontSizeToolStripComboBox
        // 
        fontSizeToolStripComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
        fontSizeToolStripComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
        fontSizeToolStripComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        fontSizeToolStripComboBox.Items.AddRange(new object[] { 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72 });
        fontSizeToolStripComboBox.Name = "fontSizeToolStripComboBox";
        fontSizeToolStripComboBox.Padding = new System.Windows.Forms.Padding(5);
        fontSizeToolStripComboBox.Size = new System.Drawing.Size(75, 38);
        // 
        // boldToolStripButton
        // 
        boldToolStripButton.BackColor = System.Drawing.SystemColors.ControlLight;
        boldToolStripButton.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        boldToolStripButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 0);
        boldToolStripButton.Name = "boldToolStripButton";
        boldToolStripButton.Padding = new System.Windows.Forms.Padding(5);
        boldToolStripButton.Size = new System.Drawing.Size(35, 36);
        boldToolStripButton.Text = "B";
        // 
        // italicToolStripButton
        // 
        italicToolStripButton.BackColor = System.Drawing.SystemColors.ControlLight;
        italicToolStripButton.Font = new System.Drawing.Font("Times New Roman", 10.8F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic)), System.Drawing.GraphicsUnit.Point, ((byte)0));
        italicToolStripButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 0);
        italicToolStripButton.Name = "italicToolStripButton";
        italicToolStripButton.Padding = new System.Windows.Forms.Padding(5);
        italicToolStripButton.Size = new System.Drawing.Size(31, 36);
        italicToolStripButton.Text = "I";
        // 
        // underlineToolStripButton
        // 
        underlineToolStripButton.BackColor = System.Drawing.SystemColors.ControlLight;
        underlineToolStripButton.Font = new System.Drawing.Font("Times New Roman", 10.8F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline)), System.Drawing.GraphicsUnit.Point, ((byte)0));
        underlineToolStripButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 0);
        underlineToolStripButton.Name = "underlineToolStripButton";
        underlineToolStripButton.Padding = new System.Windows.Forms.Padding(5);
        underlineToolStripButton.Size = new System.Drawing.Size(36, 36);
        underlineToolStripButton.Text = "U";
        // 
        // toolStripSeparator6
        // 
        toolStripSeparator6.Name = "toolStripSeparator6";
        toolStripSeparator6.Size = new System.Drawing.Size(6, 38);
        // 
        // richTextBox
        // 
        richTextBox.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        richTextBox.Location = new System.Drawing.Point(0, 64);
        richTextBox.Name = "richTextBox";
        richTextBox.Size = new System.Drawing.Size(589, 389);
        richTextBox.TabIndex = 2;
        richTextBox.Text = "";
        // 
        // fontDialog
        // 
        fontDialog.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        // 
        // openFileDialog
        // 
        openFileDialog.Filter = "Documents|*.txt;*.rtf";
        // 
        // saveFileDialog
        // 
        saveFileDialog.Filter = "|*.rtf";
        // 
        // Bai04
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(589, 453);
        Controls.Add(richTextBox);
        Controls.Add(toolStrip);
        Controls.Add(menuStrip);
        MainMenuStrip = menuStrip;
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "Soạn thảo văn bản";
        menuStrip.ResumeLayout(false);
        menuStrip.PerformLayout();
        toolStrip.ResumeLayout(false);
        toolStrip.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.OpenFileDialog openFileDialog;
    private System.Windows.Forms.SaveFileDialog saveFileDialog;

    private System.Windows.Forms.FontDialog fontDialog;

    private System.Windows.Forms.RichTextBox richTextBox;

    private System.Windows.Forms.ToolStrip toolStrip;
    private ToolStripButton newToolStripButton;
    private ToolStripButton saveToolStripButton;
    private ToolStripSeparator toolStripSeparator5;
    private System.Windows.Forms.ToolStripComboBox fontToolStripComboBox;
    private System.Windows.Forms.ToolStripComboBox fontSizeToolStripComboBox;
    private System.Windows.Forms.ToolStripButton boldToolStripButton;
    private System.Windows.Forms.ToolStripButton italicToolStripButton;
    private System.Windows.Forms.ToolStripButton underlineToolStripButton;
    private ToolStripSeparator toolStripSeparator6;

    private MenuStrip menuStrip;
    private ToolStripMenuItem fileToolStripMenuItem;
    private ToolStripMenuItem newToolStripMenuItem;
    private ToolStripMenuItem openToolStripMenuItem;
    private ToolStripSeparator toolStripSeparator;
    private ToolStripMenuItem saveToolStripMenuItem;
    private ToolStripMenuItem exitToolStripMenuItem;
    private ToolStripMenuItem formatToolStripMenuItem;

    #endregion
}