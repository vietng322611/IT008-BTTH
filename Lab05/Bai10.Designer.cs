using System.ComponentModel;

namespace Lab05;

partial class Bai10
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
        EndCapCB = new System.Windows.Forms.ComboBox();
        StartCapCB = new System.Windows.Forms.ComboBox();
        DashCapCB = new System.Windows.Forms.ComboBox();
        LineJoinCB = new System.Windows.Forms.ComboBox();
        WidthCB = new System.Windows.Forms.ComboBox();
        DashStyleCB = new System.Windows.Forms.ComboBox();
        label6 = new System.Windows.Forms.Label();
        label5 = new System.Windows.Forms.Label();
        label3 = new System.Windows.Forms.Label();
        label4 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        label1 = new System.Windows.Forms.Label();
        panelPreview = new System.Windows.Forms.Panel();
        panel1.SuspendLayout();
        SuspendLayout();
        // 
        // panel1
        // 
        panel1.BackColor = System.Drawing.Color.Beige;
        panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        panel1.Controls.Add(EndCapCB);
        panel1.Controls.Add(StartCapCB);
        panel1.Controls.Add(DashCapCB);
        panel1.Controls.Add(LineJoinCB);
        panel1.Controls.Add(WidthCB);
        panel1.Controls.Add(DashStyleCB);
        panel1.Controls.Add(label6);
        panel1.Controls.Add(label5);
        panel1.Controls.Add(label3);
        panel1.Controls.Add(label4);
        panel1.Controls.Add(label2);
        panel1.Controls.Add(label1);
        panel1.Location = new System.Drawing.Point(1, 1);
        panel1.Name = "panel1";
        panel1.Size = new System.Drawing.Size(285, 414);
        panel1.TabIndex = 0;
        // 
        // EndCapCB
        // 
        EndCapCB.FormattingEnabled = true;
        EndCapCB.Location = new System.Drawing.Point(109, 345);
        EndCapCB.Name = "EndCapCB";
        EndCapCB.Size = new System.Drawing.Size(145, 28);
        EndCapCB.TabIndex = 23;
        // 
        // StartCapCB
        // 
        StartCapCB.FormattingEnabled = true;
        StartCapCB.Location = new System.Drawing.Point(109, 280);
        StartCapCB.Name = "StartCapCB";
        StartCapCB.Size = new System.Drawing.Size(145, 28);
        StartCapCB.TabIndex = 22;
        // 
        // DashCapCB
        // 
        DashCapCB.FormattingEnabled = true;
        DashCapCB.Location = new System.Drawing.Point(109, 215);
        DashCapCB.Name = "DashCapCB";
        DashCapCB.Size = new System.Drawing.Size(145, 28);
        DashCapCB.TabIndex = 21;
        // 
        // LineJoinCB
        // 
        LineJoinCB.FormattingEnabled = true;
        LineJoinCB.Location = new System.Drawing.Point(109, 150);
        LineJoinCB.Name = "LineJoinCB";
        LineJoinCB.Size = new System.Drawing.Size(145, 28);
        LineJoinCB.TabIndex = 20;
        // 
        // WidthCB
        // 
        WidthCB.FormattingEnabled = true;
        WidthCB.Location = new System.Drawing.Point(109, 87);
        WidthCB.Name = "WidthCB";
        WidthCB.Size = new System.Drawing.Size(145, 28);
        WidthCB.TabIndex = 19;
        // 
        // DashStyleCB
        // 
        DashStyleCB.FormattingEnabled = true;
        DashStyleCB.Location = new System.Drawing.Point(109, 20);
        DashStyleCB.Name = "DashStyleCB";
        DashStyleCB.Size = new System.Drawing.Size(145, 28);
        DashStyleCB.TabIndex = 18;
        // 
        // label6
        // 
        label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label6.Location = new System.Drawing.Point(10, 345);
        label6.Name = "label6";
        label6.Size = new System.Drawing.Size(93, 28);
        label6.TabIndex = 17;
        label6.Text = "End Cap:";
        label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // label5
        // 
        label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label5.Location = new System.Drawing.Point(10, 280);
        label5.Name = "label5";
        label5.Size = new System.Drawing.Size(93, 28);
        label5.TabIndex = 15;
        label5.Text = "Start Cap:";
        label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // label3
        // 
        label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label3.Location = new System.Drawing.Point(10, 215);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(93, 28);
        label3.TabIndex = 13;
        label3.Text = "Dash Cap:";
        label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // label4
        // 
        label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label4.Location = new System.Drawing.Point(10, 150);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(93, 28);
        label4.TabIndex = 11;
        label4.Text = "Line Join:";
        label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // label2
        // 
        label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label2.Location = new System.Drawing.Point(10, 85);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(93, 28);
        label2.TabIndex = 1;
        label2.Text = "Width:";
        label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label1.Location = new System.Drawing.Point(10, 20);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(93, 28);
        label1.TabIndex = 0;
        label1.Text = "Dash Style:";
        label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // panelPreview
        // 
        panelPreview.BackColor = System.Drawing.SystemColors.ButtonHighlight;
        panelPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        panelPreview.Location = new System.Drawing.Point(283, 1);
        panelPreview.Name = "panelPreview";
        panelPreview.Size = new System.Drawing.Size(372, 414);
        panelPreview.TabIndex = 1;
        // 
        // Bai10
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(655, 415);
        Controls.Add(panelPreview);
        Controls.Add(panel1);
        Text = "Pen Demo";
        panel1.ResumeLayout(false);
        ResumeLayout(false);
    }

    private System.Windows.Forms.Panel panelPreview;

    private System.Windows.Forms.ComboBox WidthCB;
    private System.Windows.Forms.ComboBox LineJoinCB;
    private System.Windows.Forms.ComboBox DashCapCB;
    private System.Windows.Forms.ComboBox StartCapCB;
    private System.Windows.Forms.ComboBox EndCapCB;

    private System.Windows.Forms.ComboBox DashStyleCB;

    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label6;

    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label5;

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.Panel panel1;

    #endregion
}