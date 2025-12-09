namespace Lab04;

public partial class Bai06 : Form
{
    private readonly ToolStripStatusLabel statusLabel;
    
    public Bai06()
    {
        InitializeComponent();
        statusLabel = new ToolStripStatusLabel();
        statusLabel.AutoSize = false;
        statusLabel.Spring = true;
        statusLabel.TextAlign = ContentAlignment.MiddleLeft;
        statusLabel.Text = "Đang sao chép:";
        statusStrip.Items.Add(statusLabel);

        chooseSourceBtn.Click += ChooseSource;
        chooseDesBtn.Click += ChooseDestination;
        copyBtn.Click += StartCopy;
    }

    private void ChooseSource(object? sender, EventArgs e)
    {
        using var dialog = new FolderBrowserDialog();
        dialog.Description = "Select a folder";
        dialog.UseDescriptionForTitle = true;
        dialog.ShowNewFolderButton = false;

        if (dialog.ShowDialog() == DialogResult.OK)
        {
            sourceLB.Text = dialog.SelectedPath;
            progressBar.Value = 0;
            statusLabel.Text = "Đang sao chép:";
        }
    }

    private void ChooseDestination(object? sender, EventArgs e)
    {
        using var dialog = new FolderBrowserDialog();
        dialog.Description = "Select a folder";
        dialog.UseDescriptionForTitle = true;
        dialog.ShowNewFolderButton = true;

        if (dialog.ShowDialog() == DialogResult.OK)
        {
            destinationLB.Text = dialog.SelectedPath;
            progressBar.Value = 0;
            statusLabel.Text = "Đang sao chép:";
        }
    }

    private async void StartCopy(object? sender, EventArgs e)
    {
        var source = sourceLB.Text.Trim();
        var des = destinationLB.Text.Trim();

        if (string.IsNullOrEmpty(source))
        {
            MessageBox.Show("Vui lòng chọn thư mục nguồn", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        if (string.IsNullOrEmpty(des))
        {
            MessageBox.Show("Vui lòng chọn thư mục đích", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        
        var files = Directory.GetFiles(source, "*.*", SearchOption.AllDirectories);

        progressBar.Minimum = 0;
        progressBar.Maximum = files.Length;
        progressBar.Value = 0;

        chooseSourceBtn.Enabled = false;
        chooseDesBtn.Enabled = false;
        copyBtn.Enabled = false;
        
        await Task.Run(() =>
        {
            foreach (var file in files)
            {
                var relativePath = Path.GetRelativePath(source, file);
                var destFile = Path.Combine(des, relativePath);

                Directory.CreateDirectory(Path.GetDirectoryName(destFile)!);
                File.Copy(file, destFile, true);

                Invoke(() =>
                {
                    progressBar.Value++;
                    statusLabel.Text = $"Đang sao chép: {file}";
                    toolTip.SetToolTip(statusStrip, statusLabel.Text);
                });
                Task.Delay(200).Wait();
            }
        });

        statusLabel.Text = "Hoàn thành!";
        toolTip.SetToolTip(statusStrip, statusLabel.Text);
        
        chooseSourceBtn.Enabled = true;
        chooseDesBtn.Enabled = true;
        copyBtn.Enabled = true;
        
        MessageBox.Show("Sao chép hoàn tất!");
    }
}