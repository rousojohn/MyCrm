using MyCrm.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Driver;
using MongoDB.Bson;

namespace MyCrm
{
    static class Program
    {
        private static MainForm mainForm;
        private static readonly ApplicationSettings appSettings = ApplicationSettings.Instance;

        public static MainForm MainForm { get { return Program.mainForm; } }
        public static ApplicationSettings AppSettings { get { return appSettings; } }
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
