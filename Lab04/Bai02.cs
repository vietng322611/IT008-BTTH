using System;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace Lab04;

public partial class Bai02 : Form
{
    private readonly Timer timer;

    public Bai02()
    {
        InitializeComponent();

        var dateTime = DateTime.Now;
        TimeLabel.Text = dateTime.ToString("dddd, MMMM dd, yyyy HH:mm:ss tt");
        
        timer = new Timer();
        timer.Interval = 1000;
        timer.Tick += (_, _) =>
        {
            dateTime = dateTime.AddSeconds(1);
            TimeLabel.Text = dateTime.ToString("dddd, MMMM dd, yyyy HH:mm:ss tt");
        };
        timer.Start();
    }
}