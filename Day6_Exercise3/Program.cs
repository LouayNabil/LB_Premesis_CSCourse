using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            string ip = GetAppSetting("ip", "127.0.0.1");
            int maxRecords = GetAppSettingsGeneric("maxrecords", 100);
            Console.ReadKey();
        }

        static string GetAppSetting(string key, string defaultValue)
        {
            string v = System.Configuration.ConfigurationManager.AppSettings[key];
            if (v == null)
                return defaultValue;
            else
                return v;
        }

        static T GetAppSettingsGeneric<T>(string key, T defaultValue)
        {
            string v = System.Configuration.ConfigurationManager.AppSettings[key];
            if (v == null)
                return defaultValue;
            else
                return (T)Convert.ChangeType(v, typeof(T));
        }
    }
}
