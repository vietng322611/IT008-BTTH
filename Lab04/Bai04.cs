using System.Text;

namespace Lab04;

public partial class Bai04 : Form
{
    public Bai04()
    {
        InitializeComponent();

        foreach (var font in FontFamily.Families)
            fontToolStripComboBox.Items.Add(font.Name);
        fontToolStripComboBox.SelectedIndexChanged += SetFont;
        fontToolStripComboBox.SelectedItem = "Tahoma";

        fontSizeToolStripComboBox.SelectedIndexChanged += SetFontSize;
        fontSizeToolStripComboBox.SelectedItem = 14;
        
        boldToolStripButton.Click += ToggleBold;
        italicToolStripButton.Click += ToggleItalic;
        underlineToolStripButton.Click += ToggleUnderline;

        newToolStripMenuItem.Click += NewDocument;
        newToolStripButton.Click += NewDocument;

        formatToolStripMenuItem.Click += SelectFont;

        openToolStripMenuItem.Click += OpenFile;
        
        saveToolStripButton.Click += SaveFile;
        saveToolStripMenuItem.Click += SaveFile;

        exitToolStripMenuItem.Click += (_, _) => Close();
    }

    private void SetFont(object? sender, EventArgs e)
    {
        var name = fontToolStripComboBox.SelectedItem!.ToString();
        if (richTextBox.SelectionFont != null)
        {
            richTextBox.SelectionFont = new Font(
                name,
                richTextBox.SelectionFont.Size,
                richTextBox.SelectionFont.Style
            );
        }
    }
    
    private void SetFontSize(object? sender, EventArgs e)
    {
        var size = (int)fontSizeToolStripComboBox.SelectedItem!;
        if (richTextBox.SelectionFont != null)
        {
            richTextBox.SelectionFont = new Font(
                richTextBox.SelectionFont.FontFamily,
                size,
                richTextBox.SelectionFont.Style
            );
        }
    }
    
    private void ToggleBold(object? sender, EventArgs e)
    {
        if (richTextBox.SelectionFont == null) return;
        
        var style = richTextBox.SelectionFont.Style;
        style ^= FontStyle.Bold;

        richTextBox.SelectionFont = new Font(
            richTextBox.SelectionFont, style
        );
    }
    
    private void ToggleItalic(object? sender, EventArgs e)
    {
        if (richTextBox.SelectionFont == null) return;
        
        var style = richTextBox.SelectionFont.Style;
        style ^= FontStyle.Italic;

        richTextBox.SelectionFont = new Font(
            richTextBox.SelectionFont, style
        );
    }

    private void ToggleUnderline(object? sender, EventArgs e)
    {
        if (richTextBox.SelectionFont == null) return;
        
        var style = richTextBox.SelectionFont.Style;
        style ^= FontStyle.Underline;

        richTextBox.SelectionFont = new Font(
            richTextBox.SelectionFont, style
        );
    }

    private void NewDocument(object? sender, EventArgs e)
    {
        openFileDialog.FileName = saveFileDialog.FileName = ""; // new file = haven't open/save
        richTextBox.Text = "";
        richTextBox.SelectionFont = new Font("Tahoma", 14, FontStyle.Regular);
        fontToolStripComboBox.SelectedItem = "Tahoma";
        fontSizeToolStripComboBox.SelectedItem = 14;
    }

    private void SelectFont(object? sender, EventArgs e)
    {
        if (fontDialog.ShowDialog() != DialogResult.OK) return;
        
        richTextBox.SelectionFont = fontDialog.Font;
        fontToolStripComboBox.SelectedItem = fontDialog.Font.Name;
        fontSizeToolStripComboBox.SelectedItem = fontDialog.Font.Size;
    }

    private void OpenFile(object? sender, EventArgs e)
    {
        if (openFileDialog.ShowDialog() != DialogResult.OK) return;

        var filePath = openFileDialog.FileName;
        var ext = Path.GetExtension(filePath).ToLowerInvariant();

        richTextBox.LoadFile(filePath,
            ext.Equals(".rtf", StringComparison.CurrentCultureIgnoreCase)
                ? RichTextBoxStreamType.RichText
                : RichTextBoxStreamType.PlainText);

        fontToolStripComboBox.SelectedItem = "Tahoma"; // reset
        fontSizeToolStripComboBox.SelectedItem = 14;
        
        saveFileDialog.FileName = filePath; // cheap trick
    }
    
    private void SaveFile(object? sender, EventArgs e)
    {
        var filePath = saveFileDialog.FileName;
        if (
            string.IsNullOrEmpty(filePath) ||
            filePath != openFileDialog.FileName
        )
        {
            if (saveFileDialog.ShowDialog() != DialogResult.OK) return;

            filePath = saveFileDialog.FileName;
            openFileDialog.FileName = filePath;
        }

        var ext = Path.GetExtension(filePath).ToLowerInvariant();
        if (ext.Equals(".rtf", StringComparison.CurrentCultureIgnoreCase))
            richTextBox.SaveFile(filePath, RichTextBoxStreamType.RichText);
        else
            File.WriteAllText(filePath, richTextBox.Text, Encoding.UTF8);
        
        MessageBox.Show("Lưu văn bản thành công", "Lưu thành công", MessageBoxButtons.OK);
    }
}