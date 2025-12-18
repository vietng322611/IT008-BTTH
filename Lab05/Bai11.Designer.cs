using System.ComponentModel;

namespace Lab05;

partial class Bai11
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
        panel1 = new System.Windows.Forms.Panel();
        groupBox3 = new System.Windows.Forms.GroupBox();
        gradientRB = new System.Windows.Forms.RadioButton();
        textureRB = new System.Windows.Forms.RadioButton();
        hatchRB = new System.Windows.Forms.RadioButton();
        solidRB = new System.Windows.Forms.RadioButton();
        groupBox2 = new System.Windows.Forms.GroupBox();
        colorBtn = new System.Windows.Forms.Button();
        widthTB = new System.Windows.Forms.TextBox();
        label1 = new System.Windows.Forms.Label();
        groupBox1 = new System.Windows.Forms.GroupBox();
        ellipseRB = new System.Windows.Forms.RadioButton();
        rectRB = new System.Windows.Forms.RadioButton();
        lineRB = new System.Windows.Forms.RadioButton();
        pictureBox = new System.Windows.Forms.PictureBox();
        colorDialog = new System.Windows.Forms.ColorDialog();
        panel1.SuspendLayout();
        groupBox3.SuspendLayout();
        groupBox2.SuspendLayout();
        groupBox1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
        SuspendLayout();
        // 
        // panel1
        // 
        panel1.BackColor = System.Drawing.Color.Beige;
        panel1.Controls.Add(groupBox3);
        panel1.Controls.Add(groupBox2);
        panel1.Controls.Add(groupBox1);
        panel1.Location = new System.Drawing.Point(1, 1);
        panel1.Name = "panel1";
        panel1.Size = new System.Drawing.Size(250, 624);
        panel1.TabIndex = 0;
        // 
        // groupBox3
        // 
        groupBox3.Controls.Add(gradientRB);
        groupBox3.Controls.Add(textureRB);
        groupBox3.Controls.Add(hatchRB);
        groupBox3.Controls.Add(solidRB);
        groupBox3.ForeColor = System.Drawing.Color.Blue;
        groupBox3.Location = new System.Drawing.Point(11, 314);
        groupBox3.Name = "groupBox3";
        groupBox3.Size = new System.Drawing.Size(198, 273);
        groupBox3.TabIndex = 2;
        groupBox3.TabStop = false;
        groupBox3.Text = "Brushes";
        // 
        // gradientRB
        // 
        gradientRB.ForeColor = System.Drawing.SystemColors.ControlText;
        gradientRB.Location = new System.Drawing.Point(6, 162);
        gradientRB.Name = "gradientRB";
        gradientRB.Size = new System.Drawing.Size(186, 28);
        gradientRB.TabIndex = 6;
        gradientRB.Text = "LinearGradientBrush";
        gradientRB.UseVisualStyleBackColor = true;
        // 
        // textureRB
        // 
        textureRB.ForeColor = System.Drawing.SystemColors.ControlText;
        textureRB.Location = new System.Drawing.Point(6, 116);
        textureRB.Name = "textureRB";
        textureRB.Size = new System.Drawing.Size(186, 28);
        textureRB.TabIndex = 5;
        textureRB.Text = "TextureBrush";
        textureRB.UseVisualStyleBackColor = true;
        // 
        // hatchRB
        // 
        hatchRB.ForeColor = System.Drawing.SystemColors.ControlText;
        hatchRB.Location = new System.Drawing.Point(6, 71);
        hatchRB.Name = "hatchRB";
        hatchRB.Size = new System.Drawing.Size(186, 28);
        hatchRB.TabIndex = 4;
        hatchRB.Text = "HatchBrush";
        hatchRB.UseVisualStyleBackColor = true;
        // 
        // solidRB
        // 
        solidRB.Checked = true;
        solidRB.ForeColor = System.Drawing.SystemColors.ControlText;
        solidRB.Location = new System.Drawing.Point(6, 26);
        solidRB.Name = "solidRB";
        solidRB.Size = new System.Drawing.Size(186, 28);
        solidRB.TabIndex = 3;
        solidRB.TabStop = true;
        solidRB.Text = "SolidBrush";
        solidRB.UseVisualStyleBackColor = true;
        // 
        // groupBox2
        // 
        groupBox2.Controls.Add(colorBtn);
        groupBox2.Controls.Add(widthTB);
        groupBox2.Controls.Add(label1);
        groupBox2.ForeColor = System.Drawing.Color.Blue;
        groupBox2.Location = new System.Drawing.Point(11, 172);
        groupBox2.Name = "groupBox2";
        groupBox2.Size = new System.Drawing.Size(198, 123);
        groupBox2.TabIndex = 1;
        groupBox2.TabStop = false;
        groupBox2.Text = "Pen";
        // 
        // colorBtn
        // 
        colorBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
        colorBtn.ForeColor = System.Drawing.SystemColors.ControlText;
        colorBtn.Location = new System.Drawing.Point(52, 74);
        colorBtn.Name = "colorBtn";
        colorBtn.Size = new System.Drawing.Size(111, 26);
        colorBtn.TabIndex = 2;
        colorBtn.Text = "Color...";
        colorBtn.UseVisualStyleBackColor = true;
        // 
        // widthTB
        // 
        widthTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        widthTB.Location = new System.Drawing.Point(69, 18);
        widthTB.Name = "widthTB";
        widthTB.Size = new System.Drawing.Size(78, 27);
        widthTB.TabIndex = 1;
        widthTB.Text = "1";
        widthTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        // 
        // label1
        // 
        label1.ForeColor = System.Drawing.SystemColors.ControlText;
        label1.Location = new System.Drawing.Point(7, 23);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(56, 22);
        label1.TabIndex = 0;
        label1.Text = "Width:";
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(ellipseRB);
        groupBox1.Controls.Add(rectRB);
        groupBox1.Controls.Add(lineRB);
        groupBox1.ForeColor = System.Drawing.Color.Blue;
        groupBox1.Location = new System.Drawing.Point(11, 11);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new System.Drawing.Size(198, 142);
        groupBox1.TabIndex = 0;
        groupBox1.TabStop = false;
        groupBox1.Text = "Shapes";
        // 
        // ellipseRB
        // 
        ellipseRB.ForeColor = System.Drawing.SystemColors.ControlText;
        ellipseRB.Location = new System.Drawing.Point(6, 94);
        ellipseRB.Name = "ellipseRB";
        ellipseRB.Size = new System.Drawing.Size(186, 28);
        ellipseRB.TabIndex = 2;
        ellipseRB.Text = "Ellipse";
        ellipseRB.UseVisualStyleBackColor = true;
        // 
        // rectRB
        // 
        rectRB.ForeColor = System.Drawing.SystemColors.ControlText;
        rectRB.Location = new System.Drawing.Point(6, 60);
        rectRB.Name = "rectRB";
        rectRB.Size = new System.Drawing.Size(186, 28);
        rectRB.TabIndex = 1;
        rectRB.Text = "Rectangle";
        rectRB.UseVisualStyleBackColor = true;
        // 
        // lineRB
        // 
        lineRB.Checked = true;
        lineRB.ForeColor = System.Drawing.SystemColors.ControlText;
        lineRB.Location = new System.Drawing.Point(6, 26);
        lineRB.Name = "lineRB";
        lineRB.Size = new System.Drawing.Size(186, 28);
        lineRB.TabIndex = 0;
        lineRB.TabStop = true;
        lineRB.Text = "Line";
        lineRB.UseVisualStyleBackColor = true;
        // 
        // pictureBox
        // 
        pictureBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
        pictureBox.Location = new System.Drawing.Point(250, 1);
        pictureBox.Name = "pictureBox";
        pictureBox.Size = new System.Drawing.Size(549, 624);
        pictureBox.TabIndex = 1;
        pictureBox.TabStop = false;
        // 
        // Bai11
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(801, 625);
        Controls.Add(pictureBox);
        Controls.Add(panel1);
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "Draw Shape";
        panel1.ResumeLayout(false);
        groupBox3.ResumeLayout(false);
        groupBox2.ResumeLayout(false);
        groupBox2.PerformLayout();
        groupBox1.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button colorBtn;

    private System.Windows.Forms.TextBox widthTB;

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.RadioButton gradientRB;

    private System.Windows.Forms.RadioButton textureRB;
    private System.Windows.Forms.RadioButton hatchRB;
    private System.Windows.Forms.RadioButton solidRB;

    private System.Windows.Forms.RadioButton rectRB;
    private System.Windows.Forms.RadioButton ellipseRB;

    private System.Windows.Forms.RadioButton lineRB;

    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.GroupBox groupBox3;

    private System.Windows.Forms.GroupBox groupBox1;

    private System.Windows.Forms.ColorDialog colorDialog;

    private System.Windows.Forms.PictureBox pictureBox;

    private System.Windows.Forms.Panel panel1;

    #endregion
}