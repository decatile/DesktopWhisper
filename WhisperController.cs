using ShortWhisper.Properties;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace ShortWhisper
{
    internal class WhisperController
    {
        public static Process Process = null;

        public static void Start()
        {
            Process?.Kill();
            Process = null;
            try
            {
                Process = Process.Start(new ProcessStartInfo(
                        Settings.Default.ServerBinaryPath,
                        $"-m {Settings.Default.ModelPath} --port {Settings.Default.ServerPort}"
                )
                { WindowStyle = ProcessWindowStyle.Hidden });
            }
            catch (Exception e)
            {
                MessageBox.Show($"Cannot start whisper server. Perhaps, you need to fill settings. Then save and restart server.\nInner error: {e.Message}");
            }
        }
    }
}
