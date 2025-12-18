using System.Drawing.Drawing2D;
using Timer = System.Windows.Forms.Timer;

namespace Lab05;

public partial class Bai08 : Form
{
    private readonly int cx;
    private readonly int cy;
    
    public Bai08()
    {
        InitializeComponent();
        DoubleBuffered = true;
        cx = ClientSize.Width / 2;
        cy = ClientSize.Height / 2;

        var timer = new Timer();
        timer.Interval = 1000;
        timer.Tick += (_, _) =>
        {
            Invalidate();
        };
        timer.Start();
        
        this.Paint += OnPaint;
    }

    private void OnPaint(object? sender, PaintEventArgs e)
    {
        var g = e.Graphics;
        g.SmoothingMode = SmoothingMode.AntiAlias;
        var dateTime = DateTime.Now;
        
        DrawCircle(g);
        DrawSecond(g, dateTime.Second);
        DrawMinute(g, dateTime.Minute);
        DrawHour(g, dateTime.Hour);
    }

    private void DrawSecond(Graphics g, int second)
    {
        var radius = cy - 60;
        var angle = (second * 6 - 90) * Math.PI / 180.0;
            
        var x = cx + radius * Math.Cos(angle);
        var y = cy + radius * Math.Sin(angle);
            
        g.DrawLine(new Pen(Color.White), new PointF(cx, cy), new PointF((float)x, (float)y));
    }

    private void DrawMinute(Graphics g, int minute)
    {
        float angle = minute * 6;

        PointF[] minuteHand =
        [
            new(0, -220),
            new(14, 0),
            new(0, 220/3f),
            new(-14, 0)
        ];
        
        using (var matrix = new Matrix())
        {
            matrix.Rotate(angle);
            matrix.Translate(cx, cy, MatrixOrder.Append);
            matrix.TransformPoints(minuteHand);
        }

        g.DrawPolygon(Pens.White, minuteHand);
    }

    private void DrawHour(Graphics g, int hour)
    {
        float angle = hour * 30; 

        PointF[] hourHand =
        [
            new(0, -170),
            new(25, 0),
            new(0, 170/3f),
            new(-25, 0)
        ];
        
        using (var matrix = new Matrix())
        {
            matrix.Rotate(angle);
            matrix.Translate(cx, cy, MatrixOrder.Append);
            matrix.TransformPoints(hourHand);
        }

        g.DrawPolygon(Pens.White, hourHand);
    }
    
    private void DrawCircle(Graphics g)
    {
        var radius = cy - 20;
        
        for (var i = 0; i < 60; i++)
        {
            var angle = (i * 6 - 90) * Math.PI / 180.0;
            
            var x = cx + radius * Math.Cos(angle);
            var y = cy + radius * Math.Sin(angle);
            
            var size = (i % 5 == 0) ? 21 : 7;
            
            var drawX = (float)(x - size / 2.0);
            var drawY = (float)(y - size / 2.0);
            
            g.FillEllipse(new SolidBrush(Color.White), new RectangleF(drawX, drawY, size, size));
        }
    }
}