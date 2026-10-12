using DO;

namespace Dal
{
    internal static class DataSource
    {
        internal static List<Student?> Students = new();
        internal static List<Test?> Tests = new();
        internal static List<Question?> Questions = new();
        internal static List<QuestionForStudent?> QuestionsForStudent = new();
        internal static List<Answer?> Answers = new();

        internal static class Config
        {
            internal const int startStudentId = 1000;
            private static int runningStudentId = startStudentId;
            internal static int NextStudentId { get { return runningStudentId++; } }

            // וכך הלאה עבור כל ישות עם מזהה רץ:
            internal const int startTestId = 100;
            private static int runningTestId = startTestId;
            internal static int NextTestId { get { return runningTestId++; } }
        }
    }
}