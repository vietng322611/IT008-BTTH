using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Lab03;

public partial class Bai1 : Form
{
    private const string OnLoadMessage = "OnLoad is called";
    private const string OnActivatedMessage = "OnActivated is called";
    private const string OnShownMessage = "OnShown is called";
    private const string OnDeactivatedMessage = "OnDeactivated is called";
    private const string OnClosingMessage = "OnClosing is called";
    private const string OnClosedMessage = "OnClosed is called";

    public Bai1()
    {
        InitializeComponent();
        Name = "Bai1";
        OpenChildBtn.Click += OpenChild;
        CloseBtn.Click += CloseForm;
    }

    private void Log(string message)
    {
        LogBox.Items.Add($"{DateTime.Now:HH:mm:ss} - {message}");
        Console.WriteLine($@"{DateTime.Now:HH:mm:ss} - {message}");
        LogBox.TopIndex = LogBox.Items.Count - 1;
    }

    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);
        Log(OnLoadMessage);
    }

    protected override void OnActivated(EventArgs e)
    {
        base.OnActivated(e);
        Log(OnActivatedMessage);
    }

    protected override void OnShown(EventArgs e)
    {
        base.OnShown(e);
        Log(OnShownMessage);
    }

    protected override void OnDeactivate(EventArgs e)
    {
        base.OnDeactivate(e);
        Log(OnDeactivatedMessage);
    }

    protected override void OnClosing(CancelEventArgs e)
    {
        base.OnClosing(e);
        Log(OnClosingMessage);
        var result = MessageBox.Show(
            "Bạn có muốn thoát chương trình?",
            "Exit",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        );

        if (result == DialogResult.No)
        {
            e.Cancel = true;
            Log("OnClosing: User cancelled closing.");
        }
        else
        {
            Log("OnClosing: User confirmed close.");
        }
    }

    protected override void OnClosed(EventArgs e)
    {
        base.OnClosed(e);
        Log(OnClosedMessage);
    }

    private static void OpenChild(object? sender, EventArgs e)
    {
        var childForm = new Bai1();
        childForm.Text = "Child Form";
        childForm.ShowDialog();
    }

    private void CloseForm(object? sender, EventArgs e)
    {
        Close();
    }
}