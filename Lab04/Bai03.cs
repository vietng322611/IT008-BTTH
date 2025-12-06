using AxWMPLib;
using Timer = System.Windows.Forms.Timer;

namespace Lab04;

public partial class Bai03 : Form
{
    private readonly AxWindowsMediaPlayer player;
    
    public Bai03()
    {
        InitializeComponent();
        
        var statusLabel = new ToolStripStatusLabel();
        statusStrip.Items.Add(statusLabel);

        player = new AxWindowsMediaPlayer();
        player.BeginInit();
        player.Location = new Point(12, 31);
        player.Size = new Size(958, 597);
        Controls.Add(player);
        player.EndInit();

        var dateTime = DateTime.Now;
        statusLabel.Text = $"Hôm nay là ngày {dateTime:dd/MM/yyyy} - Bây giờ là {dateTime:hh:mm:ss tt}";
        
        var timer = new Timer();
        timer.Interval = 1000;
        timer.Tick += (_, _) =>
        {
            dateTime = dateTime.AddSeconds(1);
            statusLabel.Text = $"Hôm nay là ngày {dateTime:dd/MM/yyyy} - Bây giờ là {dateTime:hh:mm:ss tt}";
        };
        timer.Start();

        openToolStripMenuItem.Click += OpenMedia;
        exitToolStripMenuItem.Click += (_, _) => Close();
    }

    private void OpenMedia(object? sender, EventArgs e)
    {
        if (openFileDialog.ShowDialog() != DialogResult.OK) return;
        PlayMedia(openFileDialog.FileName);
    }
    
    private void PlayMedia(string filePath)
    {
        player.URL = filePath;
        player.Ctlcontrols.play();
    }
}