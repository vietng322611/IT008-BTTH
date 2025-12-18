namespace Lab05;

partial class Bai04
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
        label1 = new System.Windows.Forms.Label();
        groupBox1 = new System.Windows.Forms.GroupBox();
        rightRB = new System.Windows.Forms.RadioButton();
        centerRB = new System.Windows.Forms.RadioButton();
        leftRB = new System.Windows.Forms.RadioButton();
        textDisplay = new System.Windows.Forms.Label();
        fontCB = new System.Windows.Forms.ComboBox();
        boldCB = new System.Windows.Forms.CheckBox();
        italicCB = new System.Windows.Forms.CheckBox();
        underlineCB = new System.Windows.Forms.CheckBox();
        sizeCB = new System.Windows.Forms.ComboBox();
        label3 = new System.Windows.Forms.Label();
        label4 = new System.Windows.Forms.Label();
        colorBtn = new System.Windows.Forms.Button();
        colorDialog = new System.Windows.Forms.ColorDialog();
        groupBox1.SuspendLayout();
        SuspendLayout();
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label1.Location = new System.Drawing.Point(17, 52);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(59, 28);
        label1.TabIndex = 0;
        label1.Text = "Font";
        label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(rightRB);
        groupBox1.Controls.Add(centerRB);
        groupBox1.Controls.Add(leftRB);
        groupBox1.Location = new System.Drawing.Point(27, 218);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new System.Drawing.Size(140, 125);
        groupBox1.TabIndex = 1;
        groupBox1.TabStop = false;
        groupBox1.Text = "Align Text";
        // 
        // rightRB
        // 
        rightRB.Location = new System.Drawing.Point(6, 90);
        rightRB.Name = "rightRB";
        rightRB.Size = new System.Drawing.Size(80, 26);
        rightRB.TabIndex = 2;
        rightRB.Text = "Right";
        rightRB.UseVisualStyleBackColor = true;
        // 
        // centerRB
        // 
        centerRB.Checked = true;
        centerRB.Location = new System.Drawing.Point(6, 58);
        centerRB.Name = "centerRB";
        centerRB.Size = new System.Drawing.Size(80, 26);
        centerRB.TabIndex = 1;
        centerRB.TabStop = true;
        centerRB.Text = "Center";
        centerRB.UseVisualStyleBackColor = true;
        // 
        // leftRB
        // 
        leftRB.Location = new System.Drawing.Point(6, 26);
        leftRB.Name = "leftRB";
        leftRB.Size = new System.Drawing.Size(80, 26);
        leftRB.TabIndex = 0;
        leftRB.Text = "Left";
        leftRB.UseVisualStyleBackColor = true;
        // 
        // textDisplay
        // 
        textDisplay.BackColor = System.Drawing.SystemColors.ButtonHighlight;
        textDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        textDisplay.Font = new System.Drawing.Font("Arial", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) | System.Drawing.FontStyle.Underline)), System.Drawing.GraphicsUnit.Point, ((byte)0));
        textDisplay.ForeColor = System.Drawing.Color.DeepPink;
        textDisplay.Location = new System.Drawing.Point(207, 247);
        textDisplay.Name = "textDisplay";
        textDisplay.Size = new System.Drawing.Size(278, 73);
        textDisplay.TabIndex = 2;
        textDisplay.Text = "Hello";
        textDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // fontCB
        // 
        fontCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        fontCB.FormattingEnabled = true;
        fontCB.Location = new System.Drawing.Point(82, 52);
        fontCB.Name = "fontCB";
        fontCB.Size = new System.Drawing.Size(179, 28);
        fontCB.TabIndex = 6;
        // 
        // boldCB
        // 
        boldCB.Checked = true;
        boldCB.CheckState = System.Windows.Forms.CheckState.Checked;
        boldCB.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        boldCB.Location = new System.Drawing.Point(27, 98);
        boldCB.Name = "boldCB";
        boldCB.Size = new System.Drawing.Size(49, 52);
        boldCB.TabIndex = 7;
        boldCB.Text = "B";
        boldCB.TextAlign = System.Drawing.ContentAlignment.TopCenter;
        boldCB.UseVisualStyleBackColor = true;
        // 
        // italicCB
        // 
        italicCB.Checked = true;
        italicCB.CheckState = System.Windows.Forms.CheckState.Checked;
        italicCB.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)0));
        italicCB.Location = new System.Drawing.Point(82, 98);
        italicCB.Name = "italicCB";
        italicCB.Size = new System.Drawing.Size(44, 52);
        italicCB.TabIndex = 8;
        italicCB.Text = "I";
        italicCB.TextAlign = System.Drawing.ContentAlignment.TopCenter;
        italicCB.UseVisualStyleBackColor = true;
        // 
        // underlineCB
        // 
        underlineCB.Checked = true;
        underlineCB.CheckState = System.Windows.Forms.CheckState.Checked;
        underlineCB.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)0));
        underlineCB.Location = new System.Drawing.Point(132, 98);
        underlineCB.Name = "underlineCB";
        underlineCB.Size = new System.Drawing.Size(61, 52);
        underlineCB.TabIndex = 9;
        underlineCB.Text = "U";
        underlineCB.TextAlign = System.Drawing.ContentAlignment.TopCenter;
        underlineCB.UseVisualStyleBackColor = true;
        // 
        // sizeCB
        // 
        sizeCB.FormattingEnabled = true;
        sizeCB.Location = new System.Drawing.Point(366, 52);
        sizeCB.Name = "sizeCB";
        sizeCB.Size = new System.Drawing.Size(78, 28);
        sizeCB.TabIndex = 11;
        sizeCB.Text = "28";
        // 
        // label3
        // 
        label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label3.Location = new System.Drawing.Point(301, 50);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(59, 28);
        label3.TabIndex = 10;
        label3.Text = "Size";
        label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // label4
        // 
        label4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label4.Location = new System.Drawing.Point(288, 98);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(72, 28);
        label4.TabIndex = 12;
        label4.Text = "Color";
        label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // colorBtn
        // 
        colorBtn.BackColor = System.Drawing.Color.DeepPink;
        colorBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)224)), ((int)((byte)224)), ((int)((byte)224)));
        colorBtn.FlatAppearance.BorderSize = 0;
        colorBtn.Location = new System.Drawing.Point(366, 98);
        colorBtn.Name = "colorBtn";
        colorBtn.Size = new System.Drawing.Size(38, 28);
        colorBtn.TabIndex = 13;
        colorBtn.UseVisualStyleBackColor = false;
        // 
        // Bai04
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(497, 355);
        Controls.Add(colorBtn);
        Controls.Add(label4);
        Controls.Add(sizeCB);
        Controls.Add(label3);
        Controls.Add(underlineCB);
        Controls.Add(italicCB);
        Controls.Add(boldCB);
        Controls.Add(fontCB);
        Controls.Add(textDisplay);
        Controls.Add(groupBox1);
        Controls.Add(label1);
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "Form1";
        groupBox1.ResumeLayout(false);
        ResumeLayout(false);
    }

    private System.Windows.Forms.ColorDialog colorDialog;

    private System.Windows.Forms.Button colorBtn;

    private System.Windows.Forms.Label label4;

    private System.Windows.Forms.Label label3;

    private System.Windows.Forms.CheckBox underlineCB;

    private System.Windows.Forms.CheckBox italicCB;

    private System.Windows.Forms.ComboBox fontCB;

    private System.Windows.Forms.RadioButton centerRB;
    private System.Windows.Forms.RadioButton rightRB;

    private System.Windows.Forms.RadioButton leftRB;

    private System.Windows.Forms.ComboBox sizeCB;

    private System.Windows.Forms.CheckBox boldCB;

    private System.Windows.Forms.Label textDisplay;

    private System.Windows.Forms.GroupBox groupBox1;

    private System.Windows.Forms.Label label1;

    #endregion
}