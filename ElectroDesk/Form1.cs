using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.Win32;

namespace ElectroDesk
{
    public partial class ED_Form : Form
    {
        public class WinRun
        {            

            private static bool IsStartupItem()
            {
                RegistryKey rkApp = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

                if (rkApp.GetValue("ElectroDesk") == null)
                    return false;
                else
                    return true;
            }

            public static void Set()
            {
                RegistryKey rkApp = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

                if (!IsStartupItem()) rkApp.SetValue("ElectroDesk", Application.ExecutablePath.ToString());
            }

            public static void UnSet()
            {
                RegistryKey rkApp = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

                if (IsStartupItem()) rkApp.DeleteValue("ElectroDesk", false);
            }


        }
        
        public sealed class Wallpaper
        /* 
         * Based on http://stackoverflow.com/questions/1061678/change-desktop-wallpaper-using-code-in-net
         * 
         */
        {
            Wallpaper() { }

            const int SPI_SETDESKWALLPAPER = 20;
            const int SPIF_UPDATEINIFILE = 0x01;
            const int SPIF_SENDWININICHANGE = 0x02;

            [DllImport("user32.dll", CharSet = CharSet.Auto)]
            static extern int SystemParametersInfo(int uAction, int uParam, string lpvParam, int fuWinIni);

            public enum Style : int
            {
                Tiled,
                Centered,
                Stretched
            }

            public static void Set(Uri uri)
            {
                Stream s = new WebClient().OpenRead(uri.ToString());

                Image img = Image.FromStream(s);
                string tempPath = Path.Combine(Path.GetTempPath(), "wallpaper.bmp");
                img.Save(tempPath, System.Drawing.Imaging.ImageFormat.Bmp);

                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Control Panel\Desktop", true);

                int major = Environment.OSVersion.Version.Major;
                int minor = Environment.OSVersion.Version.Minor;

                key.SetValue(@"TileWallpaper", 0.ToString());

                if ((major >= 6) && (minor >= 2))
                {
                    key.SetValue(@"WallpaperStyle", 0.ToString());
                }
                else
                {
                    key.SetValue(@"WallpaperStyle", 1.ToString());
                }

                SystemParametersInfo(SPI_SETDESKWALLPAPER,
                    0,
                    tempPath,
                    SPIF_UPDATEINIFILE | SPIF_SENDWININICHANGE);
            }
        }

        public ED_Form()
        {
            InitializeComponent();
        }

        private void UpdBtn_Click(object sender, EventArgs e)
        {

            Uri link = new Uri(PicName.Text);

            try
            {
                Wallpaper.Set(link);
            }
            catch (System.Net.WebException)
            {
                TrayIcon.BalloonTipText = "Произошла ошибка при обновлении. Похоже нет связи с Интернетом.";
                TrayIcon.BalloonTipIcon = ToolTipIcon.Error;
                TrayIcon.ShowBalloonTip(3000);
            }

            if (TrayBaloon.Checked) 
            {
                TrayIcon.BalloonTipIcon = ToolTipIcon.Info;
                TrayIcon.BalloonTipText = "Фон рабочего стола обновлен";
                TrayIcon.ShowBalloonTip(3000); 
            }
            WpUpdTimer.Interval = int.Parse(UpdTime.Text) * 1000 * 60;
        }

        private void ED_Form_Resize(object sender, EventArgs e)
        {

            if (FormWindowState.Minimized == this.WindowState)
            {
                TrayIcon.Visible = true;
                this.Hide();
            }

            else if (FormWindowState.Normal == this.WindowState)
            {
                TrayIcon.Visible = false;
            }
        }

        private void TrayIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void ED_Form_Load(object sender, EventArgs e)
        {
            PicName.SelectedIndex   = Properties.Settings.Default.PicName;
            AutoRun.Checked         = Properties.Settings.Default.AutoRun;
            UpdTime.Text            = Properties.Settings.Default.UpdTime;
            StartIntray.Checked     = Properties.Settings.Default.StartInTray;
            TrayBaloon.Checked      = Properties.Settings.Default.TrayBaloon;
            TrayIcon.BalloonTipTitle = "ElectroDesk";
        }

        private void AutoRun_CheckedChanged(object sender, EventArgs e)
        {
            if (AutoRun.Checked) { WinRun.Set(); } else { WinRun.UnSet(); }
            Properties.Settings.Default.AutoRun = AutoRun.Checked;
            Properties.Settings.Default.Save();
        }

        private void PicName_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.PicName = PicName.SelectedIndex;
            Properties.Settings.Default.Save();
        }

        private void UpdTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            WpUpdTimer.Interval = int.Parse(UpdTime.Text) * 1000 * 60;
            Properties.Settings.Default.UpdTime = UpdTime.Text;
            Properties.Settings.Default.Save();
        }

        private void StarIntray_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.StartInTray = StartIntray.Checked;
            Properties.Settings.Default.Save();
        }

        private void TrayBaloon_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.TrayBaloon = TrayBaloon.Checked;
            Properties.Settings.Default.Save();
        }

        private void trayicon_MouseClick(object sender, MouseEventArgs e)
        {
            TrayMenu.Show(Cursor.Position.X, Cursor.Position.Y);
        }

        private void открытьНастройкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
