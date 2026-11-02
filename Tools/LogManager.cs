using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Tools
{
    public class LogManager
    {
        private static String path = "Log";

        public static String getFolderPath()
        { return path + @"\" + DateTime.Now.Month + "-" + DateTime.Now.Year; }//9-26

        public static String getFilePath()
        { return getFolderPath() + DateTime.Now.Day + ".txt"; }

        public static void writeToLog(String project, String funcName, String message)
        {
            if (!Directory.Exists(getFolderPath()))
            {
                Directory.CreateDirectory(getFolderPath());
            }

            if (File.Exists(getFilePath()))
            {
                // קובץ קיים: מחברים אליו
                using (StreamWriter writer = new StreamWriter(getFilePath(), append: true))
                {
                    writer.WriteLine($"{DateTime.Now}\t{project}.{funcName}:\t{message}");
                }
            }
            else
            {
                // קובץ לא קיים: יוצרים חדש
                using (StreamWriter writer = new StreamWriter(getFilePath(), append: false))
                {
                    writer.WriteLine($"{DateTime.Now}\t{project}.{funcName}:\t{message}");
                }
            }



        }

        public static void clearLog()
        {
            DateTime dateTime = DateTime.Now.AddMonths(-2);
            string[] subDirectories = Directory.GetDirectories(path);
            foreach (string dir in subDirectories)
            {
                if (Convert.ToInt32(dir.Substring(dir.Length - 2)) < dateTime.Year
                    || Convert.ToInt32(dir.Substring(0, dir.Length - 4)) < dateTime.Month)
                {
                    Directory.Delete(dir, recursive: true);
                }
            }

        }
    }
}