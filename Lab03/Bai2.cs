using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab03;

public partial class Bai2 : Form
{
    public Bai2()
    {
        InitializeComponent();
        Paint += PaintRandom;
        PaintBtn.Click += InvalidatePaint;
    }

    private void PaintRandom(object? sender, EventArgs e)
    {
        var r = new Random();
        var gx = CreateGraphics();
        gx.DrawString($"Paint Event", Font, Brushes.Black, r.Next(0, 800), r.Next(0, 500));
    }

    private void InvalidatePaint(object? sender, EventArgs e)
    {
        Invalidate();
    }
}