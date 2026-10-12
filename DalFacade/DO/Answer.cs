namespace DO;

/// <summary>
/// ישות נתונים עבור תשובה אפשרית לשאלה.
/// כל תשובה שייכת לשאלה מסוימת ומכילה את תוכן התשובה.
/// </summary>
/// <param name="Id">מספר מזהה ייחודי של התשובה.</param>
/// <param name="QuestionId">מזהה השאלה שאליה שייכת התשובה.</param>
/// <param name="Content">תוכן התשובה.</param>
public record Answer(int Id, int QuestionId, string Content)
{
    /// <summary>בנאי ריק - מיועד לצורך שימוש עתידי.</summary>
    public Answer() : this(0, 0, string.Empty) { }
}
