namespace Lab03;

partial class Bai1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
        LogBox = new System.Windows.Forms.ListBox();
        OpenChildBtn = new System.Windows.Forms.Button();
        CloseBtn = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // LogBox
        // 
        LogBox.FormattingEnabled = true;
        LogBox.Location = new System.Drawing.Point(1, 0);
        LogBox.Name = "LogBox";
        LogBox.Size = new System.Drawing.Size(604, 444);
        LogBox.TabIndex = 0;
        // 
        // OpenChildBtn
        // 
        OpenChildBtn.Location = new System.Drawing.Point(623, 93);
        OpenChildBtn.Name = "OpenChildBtn";
        OpenChildBtn.Size = new System.Drawing.Size(165, 45);
        OpenChildBtn.TabIndex = 1;
        OpenChildBtn.Text = "Open child form";
        OpenChildBtn.UseVisualStyleBackColor = true;
        // 
        // CloseBtn
        // 
        CloseBtn.Location = new System.Drawing.Point(623, 158);
        CloseBtn.Name = "CloseBtn";
        CloseBtn.Size = new System.Drawing.Size(165, 45);
        CloseBtn.TabIndex = 2;
        CloseBtn.Text = "Close";
        CloseBtn.UseVisualStyleBackColor = true;
        // 
        // Bai1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(CloseBtn);
        Controls.Add(OpenChildBtn);
        Controls.Add(LogBox);
        Text = "Form1";
        ResumeLayout(false);
    }

    private System.Windows.Forms.ListBox LogBox;
    private System.Windows.Forms.Button OpenChildBtn;
    private System.Windows.Forms.Button CloseBtn;

    #endregion
}