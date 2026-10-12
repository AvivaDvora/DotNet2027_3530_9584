namespace DO;

/// <summary>
/// ישות נתונים עבור שאלה.
/// שאלה שייכת לנושא מסוים, מכילה תוכן ומצביעה על התשובה הנכונה עבורה.
/// </summary>
/// <param name="Id">מספר מזהה ייחודי של השאלה.</param>
/// <param name="Subject">הנושא שבו עוסקת השאלה.</param>
/// <param name="Content">תוכן השאלה.</param>
/// <param name="CorrectAnswerId">מזהה התשובה הנכונה של השאלה.</param>
public record Question(int Id, Subject Subject, string Content, int CorrectAnswerId)
{
    /// <summary>בנאי ריק - מיועד לצורך שימוש עתידי.</summary>
    public Question() : this(0, default, string.Empty, 0) { }
}
