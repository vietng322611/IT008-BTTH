namespace Lab05;

public partial class Bai06 : Form
{
    private class FontItem
    {
        public string Text { get; set; }
        public Font Font { get; set; }
    }
    
    public Bai06()
    {
        InitializeComponent();

        foreach (var fontFamily in FontFamily.Families)
        {
            listBox.Items.Add(new FontItem
            {
                Text = fontFamily.Name,
                Font = new Font(fontFamily.Name, 16, FontStyle.Regular)
            });
        }
        listBox.DrawMode = DrawMode.OwnerDrawFixed;
        listBox.DrawItem += DrawText;
    }

    private void DrawText(object? sender, DrawItemEventArgs e)
    {
        if (e.Index < 0) return;

        e.DrawBackground();

        var item = (FontItem)listBox.Items[e.Index];

        TextRenderer.DrawText(
            e.Graphics,
            item.Text,
            item.Font,
            e.Bounds,
            e.ForeColor,
            TextFormatFlags.Left | TextFormatFlags.VerticalCenter
        );

        e.DrawFocusRectangle();
    }
}