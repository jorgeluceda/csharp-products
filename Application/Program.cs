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

            DialogResult result = DialogResult.Yes;

            if (Properties.Settings.Default.ShowLogin)
            {
                result = MessageBox.Show("WARNING! You are about to see top " +
                    "secret information. After seeing the content of this application your " +
                    "life could be in danger. Proceed at your own risk.", "Login", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }

            if(result == DialogResult.Yes)
                System.Windows.Forms.Application.Run(new MainForm());
        }
    }
}
