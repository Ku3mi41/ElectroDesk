using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ElectroDesk
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (Properties.Settings.Default.StartInTray)
            {
                Form f = new ED_Form();
                f.WindowState = FormWindowState.Minimized;
                f.ShowInTaskbar = false;
                Application.Run(f);
            }
            else
            {
                Application.Run(new ED_Form());
            }
        }
    }
}
