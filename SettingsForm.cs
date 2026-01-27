using ShortWhisper.Properties;
using System;
using System.Windows.Forms;

namespace ShortWhisper
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
            serverPathTextBox.Text = Settings.Default.ServerBinaryPath;
            modelPathTextBox.Text = Settings.Default.ModelPath;
            portTextBox.Text = Convert.ToString(Settings.Default.ServerPort);
            langTextBox.Text = Settings.Default.Language;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Settings.Default.ServerBinaryPath = serverPathTextBox.Text;
            Settings.Default.ModelPath = modelPathTextBox.Text;
            Settings.Default.ServerPort = Convert.ToInt32(portTextBox.Text);
            Settings.Default.Language = langTextBox.Text;
            Settings.Default.Save();
        }
    }
}
