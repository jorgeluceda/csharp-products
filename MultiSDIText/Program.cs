using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiSDIText
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(String[] args)
        {
            String words = "Hello World";
            Storage.Document doc = new Storage.Document();
            Storage.Text[] tex = new Storage.Text[words.Length];
            //Application.EnableVisualStyles();
            //MultiSDITextApplication.Application.Run(args);
            tex = doc.Split(words);
            Debug.WriteLine(tex);
            Debug.WriteLine(tex[0]);
            Debug.WriteLine(tex[0].Content);
            Debug.WriteLine(tex[1].Content);
        }
    }
}
