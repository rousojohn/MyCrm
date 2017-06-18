using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCrm
{
    static class Program
    {
        public static MainForm mainForm;

        public static MainForm MainForm { get { return Program.mainForm; } }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Program.mainForm = new MainForm();
            Application.Run(Program.mainForm);
        }
    }
}
