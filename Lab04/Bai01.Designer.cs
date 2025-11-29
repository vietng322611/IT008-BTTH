namespace Lab04;

partial class Bai01
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
        panel2 = new System.Windows.Forms.Panel();
        label2 = new System.Windows.Forms.Label();
        label8 = new System.Windows.Forms.Label();
        label9 = new System.Windows.Forms.Label();
        AsciiLb = new System.Windows.Forms.Label();
        KeyCodeLb = new System.Windows.Forms.Label();
        label6 = new System.Windows.Forms.Label();
        KeyValueLb = new System.Windows.Forms.Label();
        panel1 = new System.Windows.Forms.Panel();
        label1 = new System.Windows.Forms.Label();
        label3 = new System.Windows.Forms.Label();
        label4 = new System.Windows.Forms.Label();
        MouseBtnLb = new System.Windows.Forms.Label();
        MousePosLb = new System.Windows.Forms.Label();
        panel2.SuspendLayout();
        panel1.SuspendLayout();
        SuspendLayout();
        // 
        // panel2
        // 
        panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        panel2.Controls.Add(KeyValueLb);
        panel2.Controls.Add(label6);
        panel2.Controls.Add(KeyCodeLb);
        panel2.Controls.Add(AsciiLb);
        panel2.Controls.Add(label9);
        panel2.Controls.Add(label8);
        panel2.Controls.Add(label2);
        panel2.Location = new System.Drawing.Point(280, 0);
        panel2.Name = "panel2";
        panel2.Size = new System.Drawing.Size(290, 287);
        panel2.TabIndex = 1;
        // 
        // label2
        // 
        label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label2.Location = new System.Drawing.Point(-1, -1);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(290, 68);
        label2.TabIndex = 1;
        label2.Text = "Keyboard Events";
        label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // label8
        // 
        label8.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label8.Location = new System.Drawing.Point(7, 111);
        label8.Name = "label8";
        label8.Size = new System.Drawing.Size(87, 27);
        label8.TabIndex = 6;
        label8.Text = "Mã ASCII:";
        // 
        // label9
        // 
        label9.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label9.Location = new System.Drawing.Point(7, 188);
        label9.Name = "label9";
        label9.Size = new System.Drawing.Size(87, 27);
        label9.TabIndex = 7;
        label9.Text = "Key code:";
        // 
        // AsciiLb
        // 
        AsciiLb.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        AsciiLb.Location = new System.Drawing.Point(100, 111);
        AsciiLb.Name = "AsciiLb";
        AsciiLb.Size = new System.Drawing.Size(101, 27);
        AsciiLb.TabIndex = 8;
        // 
        // KeyCodeLb
        // 
        KeyCodeLb.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        KeyCodeLb.Location = new System.Drawing.Point(100, 188);
        KeyCodeLb.Name = "KeyCodeLb";
        KeyCodeLb.Size = new System.Drawing.Size(101, 27);
        KeyCodeLb.TabIndex = 9;
        // 
        // label6
        // 
        label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label6.Location = new System.Drawing.Point(7, 148);
        label6.Name = "label6";
        label6.Size = new System.Drawing.Size(100, 27);
        label6.TabIndex = 10;
        label6.Text = "Key value:";
        // 
        // KeyValueLb
        // 
        KeyValueLb.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        KeyValueLb.Location = new System.Drawing.Point(100, 148);
        KeyValueLb.Name = "KeyValueLb";
        KeyValueLb.Size = new System.Drawing.Size(70, 27);
        KeyValueLb.TabIndex = 11;
        // 
        // panel1
        // 
        panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        panel1.Controls.Add(MousePosLb);
        panel1.Controls.Add(MouseBtnLb);
        panel1.Controls.Add(label4);
        panel1.Controls.Add(label3);
        panel1.Controls.Add(label1);
        panel1.Location = new System.Drawing.Point(0, 0);
        panel1.Name = "panel1";
        panel1.Size = new System.Drawing.Size(282, 287);
        panel1.TabIndex = 0;
        // 
        // label1
        // 
        label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label1.Location = new System.Drawing.Point(-1, -1);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(282, 68);
        label1.TabIndex = 0;
        label1.Text = "Mouse Events";
        label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // label3
        // 
        label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label3.Location = new System.Drawing.Point(3, 111);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(121, 27);
        label3.TabIndex = 1;
        label3.Text = "Bạn vừa nhấn:";
        // 
        // label4
        // 
        label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label4.Location = new System.Drawing.Point(3, 188);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(121, 27);
        label4.TabIndex = 2;
        label4.Text = "Tọa độ chuột:";
        // 
        // MouseBtnLb
        // 
        MouseBtnLb.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        MouseBtnLb.Location = new System.Drawing.Point(130, 111);
        MouseBtnLb.Name = "MouseBtnLb";
        MouseBtnLb.Size = new System.Drawing.Size(101, 27);
        MouseBtnLb.TabIndex = 3;
        // 
        // MousePosLb
        // 
        MousePosLb.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        MousePosLb.Location = new System.Drawing.Point(130, 188);
        MousePosLb.Name = "MousePosLb";
        MousePosLb.Size = new System.Drawing.Size(143, 27);
        MousePosLb.TabIndex = 4;
        // 
        // Bai01
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(570, 288);
        Controls.Add(panel2);
        Controls.Add(panel1);
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "MouseEventListener";
        panel2.ResumeLayout(false);
        panel1.ResumeLayout(false);
        ResumeLayout(false);
    }

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Panel panel2;

    private System.Windows.Forms.Label KeyValueLb;
    private System.Windows.Forms.Label label6;

    private System.Windows.Forms.Label AsciiLb;
    private System.Windows.Forms.Label KeyCodeLb;

    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Label label9;

    private System.Windows.Forms.Label MousePosLb;

    private System.Windows.Forms.Label MouseBtnLb;

    private System.Windows.Forms.Label label4;

    private System.Windows.Forms.Label label3;

    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.Label label1;

    #endregion
}