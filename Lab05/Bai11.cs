using System.Drawing.Drawing2D;

namespace Lab05;

public partial class Bai11 : Form
{
    private Point startPoint;
    private Point currentPoint;
    private bool isDrawing;
    private Color currentColor = Color.Black;
    private readonly Bitmap canvas;
    private readonly Bitmap texture;
    
    public Bai11()
    {
        InitializeComponent();
        DoubleBuffered = true;
        
        canvas = new Bitmap(pictureBox.Width, pictureBox.Height);
        texture = new Bitmap("texture.jpg");
        pictureBox.Image = canvas;

        colorBtn.Click += ChooseColor;
        
        pictureBox.MouseDown += PictureBoxMouseDown;
        pictureBox.MouseMove += PictureBoxMouseMove;
        pictureBox.MouseUp += PictureBoxMouseUp;
        pictureBox.Paint += PictureBoxPaint;
    }
    
    private void ChooseColor(object? sender, EventArgs e)
    {
        if (colorDialog.ShowDialog() == DialogResult.OK)
        {
            currentColor = colorDialog.Color;
        }
    }
    
    private void PictureBoxMouseDown(object? sender, MouseEventArgs e)
    {
        if (e.Button != MouseButtons.Left) return;
        
        isDrawing = true;
        startPoint = e.Location;
        currentPoint = e.Location;
    }

    private void PictureBoxMouseMove(object? sender, MouseEventArgs e)
    {
        if (!isDrawing) return;

        currentPoint = e.Location;
        pictureBox.Invalidate();
    }

    private void PictureBoxMouseUp(object? sender, MouseEventArgs e)
    {
        if (!isDrawing) return;
        isDrawing = false;

        using var g = Graphics.FromImage(canvas);
        Draw(g);

        pictureBox.Invalidate();
    }
    
    private void PictureBoxPaint(object? sender, PaintEventArgs e)
    {
        if (!isDrawing) return;
        Draw(e.Graphics);
    }

    private void Draw(Graphics g)
    {
        g.SmoothingMode = SmoothingMode.AntiAlias;

        if (lineRB.Checked)
        {
            if (!int.TryParse(widthTB.Text, out var txtWidth))
            {
                MessageBox.Show("Độ dày không hợp lệ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            g.DrawLine(new Pen(currentColor, txtWidth), startPoint, currentPoint);
            return;
        }

        var rect = GetRectangle(startPoint, currentPoint);
        var brush = CreateBrush(rect);

        if (rectRB.Checked)
        {
            g.FillRectangle(brush, rect);
            return;
        }
        
        g.FillEllipse(brush, rect);
    }
    
    private Brush CreateBrush(Rectangle rect)
    {
        if (solidRB.Checked)
            return new SolidBrush(Color.Green);

        if (hatchRB.Checked)
            return new HatchBrush(HatchStyle.Horizontal, Color.Blue, Color.Green);

        if (!textureRB.Checked)
            return new LinearGradientBrush(
                rect,
                Color.Red,
                Color.Green,
                LinearGradientMode.Vertical
            );
        
        return new TextureBrush(texture);

    }
    
    private static Rectangle GetRectangle(Point p1, Point p2)
    {
        var rectWidth = Math.Abs(p1.X - p2.X);
        var rectHeight = Math.Abs(p1.Y - p2.Y);
        
        return new Rectangle(
            Math.Min(p1.X, p2.X),
            Math.Min(p1.Y, p2.Y),
            rectWidth != 0 ? rectWidth : 1,
            rectHeight != 0 ? rectHeight : 1
        );
    }
}