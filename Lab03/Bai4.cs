using System;
using System.Windows.Forms;

namespace Lab03;

public partial class Bai4 : Form
{
    public Bai4()
    {
        InitializeComponent();
    }

    private void ChooseColorClick(object? sender, EventArgs e)
    {
        var colorDialog = new ColorDialog();
        colorDialog.AllowFullOpen = true;
        colorDialog.Color = BackColor;

        if (colorDialog.ShowDialog() == DialogResult.OK)
        {
            BackColor = colorDialog.Color;
        }
    }
}