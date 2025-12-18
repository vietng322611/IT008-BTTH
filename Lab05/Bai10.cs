using System.Drawing.Drawing2D;

namespace Lab05;

public partial class Bai10 : Form
{
    public Bai10()
    {
        InitializeComponent();
        
        DashStyleCB.DataSource = Enum.GetValues(typeof(DashStyle));
        DashStyleCB.SelectedItem = DashStyle.DashDot;
        LineJoinCB.DataSource = Enum.GetValues(typeof(LineJoin));
        LineJoinCB.SelectedItem = LineJoin.Round;
        DashCapCB.DataSource = Enum.GetValues(typeof(DashCap));
        DashCapCB.SelectedItem = DashCap.Triangle;
        StartCapCB.DataSource = Enum.GetValues(typeof(LineCap));
        StartCapCB.SelectedItem = LineCap.Triangle;
        EndCapCB.DataSource = Enum.GetValues(typeof(LineCap));
        EndCapCB.SelectedItem = LineCap.RoundAnchor;

        // Width values
        for (var i = 1; i <= 20; i++)
            WidthCB.Items.Add(i);
        WidthCB.SelectedItem = 9;
        
        DashStyleCB.SelectedIndexChanged += OnIndexChanged;
        LineJoinCB.SelectedIndexChanged += OnIndexChanged;
        DashCapCB.SelectedIndexChanged += OnIndexChanged;
        StartCapCB.SelectedIndexChanged += OnIndexChanged;
        EndCapCB.SelectedIndexChanged += OnIndexChanged;
        WidthCB.SelectedIndexChanged += OnIndexChanged;

        panelPreview.Paint += PaintShape;
    }

    private void OnIndexChanged(object? sender, EventArgs e)
    {
        panelPreview.Invalidate();
    }

    private void PaintShape(object? sender, PaintEventArgs e)
    {
        var g = e.Graphics;
        g.SmoothingMode = SmoothingMode.AntiAlias;

        var dashStyle = (DashStyle)(DashStyleCB.SelectedItem ?? DashStyle.DashDot);
        var lineJoin  = (LineJoin)(LineJoinCB.SelectedItem ?? LineJoin.Round);
        var dashCap   = (DashCap)(DashCapCB.SelectedItem ?? DashCap.Triangle);
        var startCap  = (LineCap)(StartCapCB.SelectedItem ?? LineCap.Triangle);
        var endCap    = (LineCap)(EndCapCB.SelectedItem ?? LineCap.RoundAnchor);
        var width = int.Parse(WidthCB.SelectedItem?.ToString() ?? "9");
        
        var p = new Pen(Color.Red, width);
        p.DashStyle = dashStyle;
        p.LineJoin = lineJoin;
        p.DashCap = dashCap;
        p.StartCap = startCap;
        p.EndCap = endCap;

        var pw = panelPreview.Width;
        var ph = panelPreview.Height;
        
        Point[] line1 =
        [
            new(10, 10),
            new(pw/2 - 40, ph/2 - 40),
        ];
        
        Point[] line2 =
        [
            new(ph/2 - 60, ph/2),
            new(pw/2, ph - 10),
            new(pw/2 + 60, ph/2)
        ];

        g.DrawLines(p, line1);
        g.DrawLines(p, line2);
    }
}