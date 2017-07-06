using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;


namespace MyCrm.Classes
{
    public sealed class ApplicationSettings
    {
        private static readonly ApplicationSettings instance = new ApplicationSettings();

        private string host = string.Empty;
        private int port = 0;
        private string logsPath = string.Empty;


        static ApplicationSettings()
        { }

        private ApplicationSettings()
        { }

        public static ApplicationSettings Instance { get { return instance; } }


        public string Host { get { return host; } set { host = value; } }
        public int Port { get { return port; } set { port = value; } }
        public string LogsPath { get { return logsPath; } set { logsPath = value; } }



        public bool Save ()
        {
            try
            {
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.AppSettings.Settings["Host"].Value = "1";
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");
            }
            catch (Exception ex)
            {
                Log.Instance.Error(ex, "Error Saving Applicaion Configuration");
                return false;
            }
            return true;
        }

        public bool Read ()
        {
            try
            {
                Log.Instance.ConditionalDebug("Reading Application Configuration");
                host = ConfigurationManager.AppSettings["Host"];
                port = int.Parse(ConfigurationManager.AppSettings["Port"]);
                logsPath = ConfigurationManager.AppSettings["LogsPath"];
                Log.Instance.ConditionalDebug("Reading Application Configuration");

            }
            catch (Exception ex)
            {
                Log.Instance.Error(ex, "Error Reading Applicaion Configuration");
                return false;
            }
            return true;
        }
    }
}
