namespace Lab05;

public partial class Bai04 : Form
{
    public Bai04()
    {
        InitializeComponent();
        
        foreach (var font in FontFamily.Families)
            fontCB.Items.Add(font.Name);
        fontCB.SelectedItem = "Arial";
        fontCB.SelectedIndexChanged += ReloadFont;
        
        sizeCB.Items.AddRange([8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72]);
        sizeCB.SelectedIndexChanged += ReloadFont;
        sizeCB.KeyDown += ValidateSize;

        boldCB.Click += ReloadFont;
        italicCB.Click += ReloadFont;
        underlineCB.Click += ReloadFont;
        leftRB.Click += ChangeDirection;
        centerRB.Click += ChangeDirection;
        rightRB.Click += ChangeDirection;

        colorBtn.Click += OpenColorDialog;
    }
    
    private void ReloadFont(object? sender, EventArgs e)
    {
        var style = FontStyle.Regular;
        if (boldCB.Checked) style ^= FontStyle.Bold;
        if (italicCB.Checked) style ^= FontStyle.Italic;
        if (underlineCB.Checked) style ^= FontStyle.Underline;
        
        var font = new Font(fontCB.Text, float.Parse(sizeCB.Text), style);
        textDisplay.Font = font;
    }

    private void ValidateSize(object? sender, KeyEventArgs e)
    {
        if (e.KeyCode != Keys.Enter) return;

        if (int.TryParse(sizeCB.Text, out var size))
        {
            size = int.Max(size, 1);
            size = int.Min(size, 72);
            sizeCB.Text = size.ToString();
            ReloadFont(sender, e);
        }
        else
        {
            sizeCB.Text = ((int)textDisplay.Font.Size).ToString();
        }
    }

    private void ChangeDirection(object? sender, EventArgs e)
    {
        if (sender is not RadioButton button) return;

        var alignment = button.Name switch
        {
            "leftRB" => ContentAlignment.MiddleLeft,
            "rightRB" => ContentAlignment.MiddleRight,
            _ => ContentAlignment.MiddleCenter
        };
        textDisplay.TextAlign = alignment;
    }

    private void OpenColorDialog(object? sender, EventArgs e)
    {
        if (colorDialog.ShowDialog() == DialogResult.OK)
        {
            textDisplay.ForeColor = colorDialog.Color;
        }
    }
}