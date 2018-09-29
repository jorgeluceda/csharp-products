using System;
using System.Drawing;
using System.Windows.Forms;

namespace SingleDocumentInterface
{
    static class Program
    {
        public static Color SystemColor { get; private set; }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
