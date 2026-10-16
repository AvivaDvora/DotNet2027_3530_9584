using DO;

namespace Dal;

internal static class DataSource
{
    internal static List<Student?> Students = new();
    internal static List<Test?> Tests = new();
    internal static List<Question?> Questions = new();
    internal static List<QuestionForStudent?> QuestionsForStudent = new();
    internal static List<Answer?> Answers = new();

    internal static class Config
    {
      

        // וכך הלאה עבור כל ישות עם מזהה רץ:
        internal const int startTestId = 100;
        private static int runningTestId = startTestId;
        internal static int NextTestId { get { return runningTestId++; } }

        internal const int startQuestionId = 100;
        private static int runningQuestionId = startTestId;
        internal static int NextQuestionId { get { return runningQuestionId++; } }

        internal const int startAnswerId = 100;
        private static int runningAnswerId = startTestId;
        internal static int NextAnswerId { get { return runningAnswerId++; } }




    }
}