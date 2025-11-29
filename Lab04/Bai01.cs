namespace Lab04;

public partial class Bai01 : Form
{
    public Bai01()
    {
        InitializeComponent();
        KeyPreview = true;
        
        RegisterMouseHandlers(this);
    }
    
    private void RegisterMouseHandlers(Control parent)
    {
        // override mouse event for all controls
        foreach (Control c in parent.Controls)
        {
            c.MouseDown += Bai01_OnMouseDown;
            if (c.HasChildren)
                RegisterMouseHandlers(c);
        }
    }
    
    private void Bai01_OnMouseDown(object? o, MouseEventArgs e)
    {
        MouseBtnLb.Text = e.Button.ToString();
        MousePosLb.Text = $"X = {e.X}; Y = {e.Y}";
    }

    protected override void OnKeyPress(KeyPressEventArgs e)
    {
        base.OnKeyPress(e);
        AsciiLb.Text = ((int)e.KeyChar).ToString();
    }
    
    protected override void OnKeyDown(KeyEventArgs e)
    {
        base.OnKeyDown(e);
        KeyValueLb.Text = e.KeyValue.ToString();
        KeyCodeLb.Text = e.KeyCode.ToString();
    }
}