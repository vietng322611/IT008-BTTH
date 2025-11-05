using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab03;

public partial class Bai3 : Form
{
    public Bai3()
    {
        InitializeComponent();
        ChangeColorBtn.Click += ChangeColor;
    }

    private void ChangeColor(object? sender, EventArgs e)
    {
        var r = new Random();
        BackColor = Color.FromArgb(r.Next(0, 255), r.Next(0, 255), r.Next(0, 255));
    }
}