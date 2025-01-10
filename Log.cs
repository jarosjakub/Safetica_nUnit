using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safetica_nUnit
{
    public static class Log
    {
        public static string logPath;
        public static void Setup()
        {
            var now_temp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            var now = now_temp.Replace('.', '_').Replace(':', '_').Replace(' ', '_');
            Directory.CreateDirectory(Config.logDir);
            logPath = Config.logDir + "\\log" + now + ".txt";
            using (FileStream fs = File.Create(logPath));
        }

        public static void LogThis(string text)
        {
            using (StreamWriter outputFile = new StreamWriter(logPath, true))
            {
                var nowLog = DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss");
                outputFile.WriteLine(nowLog + ":  " + text);
            }
        }
    }
}
