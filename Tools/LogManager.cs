using System;
using System.IO;

namespace Tools
{
    public class LogManager
    {
        private static String path = "Log";

        public static String getFolderPath()
        {
            // למשל: Log\9-2026  (חודש-שנה, בלי אפס מוביל)
            return path + Path.DirectorySeparatorChar + DateTime.Now.Month + "-" + DateTime.Now.Year;
        }

        public static String getFilePath()
        {
            // למשל: Log\9-2026\4.txt  (יום בחודש)
            return getFolderPath() + Path.DirectorySeparatorChar + DateTime.Now.Day + ".txt";
        }

        public static void writeToLog(String project, String funcName, String message)
        {
            if (!Directory.Exists(getFolderPath()))
            {
                Directory.CreateDirectory(getFolderPath());
            }

            // StreamWriter עם append:true יוצר את הקובץ אם אינו קיים ופותח אותו להוספה אם קיים
            using (StreamWriter writer = new StreamWriter(getFilePath(), append: true))
            {
                writer.WriteLine($"{DateTime.Now}\t{project}.{funcName}:\t{message}");
            }
        }

        public static void clearLog()
        {
            if (!Directory.Exists(path))
            {
                return;
            }

            DateTime cutoff = DateTime.Now.AddMonths(-2);
            string[] subDirectories = Directory.GetDirectories(path);

            foreach (string dir in subDirectories)
            {
                string name = Path.GetFileName(dir); // "M-YYYY"
                string[] parts = name.Split('-');

                if (parts.Length != 2
                    || !int.TryParse(parts[0], out int month)
                    || !int.TryParse(parts[1], out int year))
                {
                    continue; // שם תיקייה לא בפורמט שלנו - לא נוגעים
                }

                // תיקייה של חודש שלם נחשבת "ישנה" אם החודש שלה לפני תאריך החיתוך
                DateTime monthStart = new DateTime(year, Math.Clamp(month, 1, 12), 1);
                if (monthStart < new DateTime(cutoff.Year, cutoff.Month, 1))
                {
                    Directory.Delete(dir, recursive: true);
                }
            }
        }
    }
}
