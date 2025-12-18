namespace Lab05;

public partial class Bai09 : Form
{
    public Bai09()
    {
        InitializeComponent();
        DoubleBuffered = true;
        
        this.Paint += PaintEvent;
        ShapeCB.SelectedIndexChanged += IndexChanged;
    }
    
    private void IndexChanged(object? sender, EventArgs e)
    {
        this.Invalidate();
    }

    private void PaintEvent(object? sender, PaintEventArgs e)
    {
        var g = e.Graphics;
        g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

        var choice = ShapeCB.SelectedItem?.ToString();

        var w = ClientSize.Width;
        var h = ClientSize.Height;

        // center screen
        var rect = new Rectangle(w/2 - 100, h/2 - 100, 200, 200);

        switch (choice)
        {
            case "Circle":
                g.DrawEllipse(Pens.Black, rect);
                break;

            case "Filled Circle":
                g.FillEllipse(Brushes.Red, rect);
                g.DrawEllipse(Pens.Black, rect);
                break;

            case "Square":
                g.DrawRectangle(Pens.Black, rect);
                break;

            case "Filled Square":
                g.FillRectangle(Brushes.Red, rect);
                g.DrawRectangle(Pens.Black, rect);
                break;

            case "Ellipse":
                g.DrawEllipse(Pens.Black, rect.X, rect.Y + 40, rect.Width, rect.Height - 80);
                break;

            case "Filled Ellipse":
                g.FillEllipse(Brushes.Red, rect.X, rect.Y + 40, rect.Width, rect.Height - 80);
                g.DrawEllipse(Pens.Black, rect.X, rect.Y + 40, rect.Width, rect.Height - 80);
                break;

            case "Pie":
                g.DrawPie(Pens.Black, rect, 0, 120);
                break;

            case "Filled Pie":
                g.FillPie(Brushes.Red, rect, 0, 120);
                g.DrawPie(Pens.Black, rect, 0, 120);
                break;
        }
    }
}