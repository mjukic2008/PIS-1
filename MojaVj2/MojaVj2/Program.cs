using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MojaVj2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form3());
            Application.Run(new Form1());

        }
    }
}
