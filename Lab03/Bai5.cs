using System;
using System.Windows.Forms;

namespace Lab03;

public partial class Bai5 : Form
{
    public Bai5()
    {
        InitializeComponent();

        Num1.KeyPress += TextBoxOnKeyPress;
        Num2.KeyPress += TextBoxOnKeyPress;

        AddBtn.Click += OnClick;
        SubBtn.Click += OnClick;
        ProdBtn.Click += OnClick;
        DivBtn.Click += OnClick;
    }
    
    private static void TextBoxOnKeyPress(object? sender, KeyPressEventArgs e)
    {
        if (sender is not TextBox textBox) return;

        if (char.IsControl(e.KeyChar))
            return;

        if (char.IsDigit(e.KeyChar))
            return;

        if (e.KeyChar == '.' && !textBox.Text.Contains('.'))
            return;

        e.Handled = true;
    }

    private void OnClick(object? sender, EventArgs e)
    {
        if (sender is not Button button) return;
        
        var ok = float.TryParse(Num1.Text, out var num1);
        ok &= float.TryParse(Num2.Text, out var num2);

        if (!ok)
        {
            MessageBox.Show(
                "Invalid input! Please enter a number.",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
        }

        Answer.Text = button.Name switch
        {
            "AddBtn" => (num1 + num2).ToString(),
            "SubBtn" => (num1 - num2).ToString(),
            "ProdBtn" => (num1 * num2).ToString(),
            "DivBtn" => (num1 / num2).ToString(),
            _ => Answer.Text
        };
    }
}