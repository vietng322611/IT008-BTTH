using System.ComponentModel;

namespace Lab04;

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
        components = new System.ComponentModel.Container();
        groupBox1 = new System.Windows.Forms.GroupBox();
        copyBtn = new System.Windows.Forms.Button();
        chooseDesBtn = new System.Windows.Forms.Button();
        chooseSourceBtn = new System.Windows.Forms.Button();
        destinationLB = new System.Windows.Forms.Label();
        sourceLB = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        label1 = new System.Windows.Forms.Label();
        groupBox2 = new System.Windows.Forms.GroupBox();
        progressBar = new System.Windows.Forms.ProgressBar();
        statusStrip = new System.Windows.Forms.StatusStrip();
        toolTip = new System.Windows.Forms.ToolTip(components);
        groupBox1.SuspendLayout();
        groupBox2.SuspendLayout();
        SuspendLayout();
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(copyBtn);
        groupBox1.Controls.Add(chooseDesBtn);
        groupBox1.Controls.Add(chooseSourceBtn);
        groupBox1.Controls.Add(destinationLB);
        groupBox1.Controls.Add(sourceLB);
        groupBox1.Controls.Add(label2);
        groupBox1.Controls.Add(label1);
        groupBox1.ForeColor = System.Drawing.Color.Blue;
        groupBox1.Location = new System.Drawing.Point(40, 41);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new System.Drawing.Size(728, 213);
        groupBox1.TabIndex = 0;
        groupBox1.TabStop = false;
        groupBox1.Text = "Sao chép tập tin";
        // 
        // copyBtn
        // 
        copyBtn.BackColor = System.Drawing.SystemColors.ControlLight;
        copyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        copyBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
        copyBtn.Location = new System.Drawing.Point(261, 175);
        copyBtn.Name = "copyBtn";
        copyBtn.Size = new System.Drawing.Size(200, 32);
        copyBtn.TabIndex = 8;
        copyBtn.Text = "Sao Chép";
        copyBtn.UseVisualStyleBackColor = false;
        // 
        // chooseDesBtn
        // 
        chooseDesBtn.BackColor = System.Drawing.SystemColors.ControlLight;
        chooseDesBtn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
        chooseDesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        chooseDesBtn.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        chooseDesBtn.ForeColor = System.Drawing.Color.Blue;
        chooseDesBtn.Location = new System.Drawing.Point(658, 116);
        chooseDesBtn.Name = "chooseDesBtn";
        chooseDesBtn.Size = new System.Drawing.Size(55, 30);
        chooseDesBtn.TabIndex = 7;
        chooseDesBtn.Text = "...";
        chooseDesBtn.UseVisualStyleBackColor = false;
        // 
        // chooseSourceBtn
        // 
        chooseSourceBtn.BackColor = System.Drawing.SystemColors.ControlLight;
        chooseSourceBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
        chooseSourceBtn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
        chooseSourceBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        chooseSourceBtn.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        chooseSourceBtn.ForeColor = System.Drawing.Color.Blue;
        chooseSourceBtn.Location = new System.Drawing.Point(658, 55);
        chooseSourceBtn.Name = "chooseSourceBtn";
        chooseSourceBtn.Size = new System.Drawing.Size(55, 30);
        chooseSourceBtn.TabIndex = 6;
        chooseSourceBtn.Text = "...";
        chooseSourceBtn.UseVisualStyleBackColor = false;
        // 
        // destinationLB
        // 
        destinationLB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        destinationLB.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        destinationLB.ForeColor = System.Drawing.SystemColors.ControlText;
        destinationLB.Location = new System.Drawing.Point(261, 118);
        destinationLB.Name = "destinationLB";
        destinationLB.Size = new System.Drawing.Size(391, 29);
        destinationLB.TabIndex = 5;
        // 
        // sourceLB
        // 
        sourceLB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        sourceLB.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        sourceLB.ForeColor = System.Drawing.SystemColors.ControlText;
        sourceLB.Location = new System.Drawing.Point(261, 55);
        sourceLB.Name = "sourceLB";
        sourceLB.Size = new System.Drawing.Size(391, 29);
        sourceLB.TabIndex = 4;
        // 
        // label2
        // 
        label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label2.ForeColor = System.Drawing.SystemColors.ControlText;
        label2.Location = new System.Drawing.Point(30, 119);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(225, 29);
        label2.TabIndex = 1;
        label2.Text = "Đường dẫn thư mục đích";
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label1.ForeColor = System.Drawing.SystemColors.ControlText;
        label1.Location = new System.Drawing.Point(30, 55);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(225, 29);
        label1.TabIndex = 0;
        label1.Text = "Đường dẫn thư mục nguồn";
        // 
        // groupBox2
        // 
        groupBox2.Controls.Add(progressBar);
        groupBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        groupBox2.ForeColor = System.Drawing.Color.Blue;
        groupBox2.Location = new System.Drawing.Point(40, 279);
        groupBox2.Name = "groupBox2";
        groupBox2.Size = new System.Drawing.Size(728, 72);
        groupBox2.TabIndex = 1;
        groupBox2.TabStop = false;
        groupBox2.Text = "Tiến trình sao chép";
        // 
        // progressBar
        // 
        progressBar.Location = new System.Drawing.Point(33, 26);
        progressBar.Name = "progressBar";
        progressBar.Size = new System.Drawing.Size(669, 29);
        progressBar.TabIndex = 2;
        // 
        // statusStrip
        // 
        statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
        statusStrip.Location = new System.Drawing.Point(0, 354);
        statusStrip.Name = "statusStrip";
        statusStrip.Size = new System.Drawing.Size(800, 22);
        statusStrip.TabIndex = 3;
        statusStrip.Text = "statusStrip1";
        // 
        // Bai06
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 376);
        Controls.Add(statusStrip);
        Controls.Add(groupBox2);
        Controls.Add(groupBox1);
        MaximizeBox = false;
        MinimizeBox = false;
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "Bai06";
        groupBox1.ResumeLayout(false);
        groupBox2.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.ToolTip toolTip;

    private System.Windows.Forms.Button copyBtn;

    private System.Windows.Forms.Button chooseDesBtn;

    private System.Windows.Forms.Button chooseSourceBtn;

    private System.Windows.Forms.Label sourceLB;

    private System.Windows.Forms.Label destinationLB;

    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.StatusStrip statusStrip;

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.ProgressBar progressBar;

    #endregion
}