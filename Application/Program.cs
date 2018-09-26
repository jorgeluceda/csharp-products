using CoreLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Application
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);

            LoginDialog dlg = new LoginDialog();

            if (Properties.Settings.Default.ShowLogin)
            {
                DialogResult result = dlg.ShowDialog();

                if (result == DialogResult.Yes)
                {
                    System.Windows.Forms.Application.Run(new MainForm());
                }
            }
            else
            {
                System.Windows.Forms.Application.Run(new MainForm());
            }
        }
    }
}
