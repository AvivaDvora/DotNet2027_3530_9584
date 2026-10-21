namespace DO;

/// <summary>
/// ישות נתונים עבור מבחן.
/// מבחן הוא אוסף שאלות בנושא מסוים שנערך בתאריך נתון וכולל מספר שאלות.
/// </summary>
/// <param name="Id">מספר מזהה ייחודי של המבחן.</param>
/// <param name="Subject">הנושא שבו עוסק המבחן.</param>
/// <param name="ExamDate">תאריך מועד הבחינה של המבחן.</param>
/// <param name="NumOfQuestions">מספר השאלות שנכללות במבחן.</param>
public record Test(int Id, Subject Subject, DateTime ExamDate, int NumOfQuestions)
{
    /// <summary>בנאי ריק - מיועד לצורך שימוש עתידי.</summary>
    public Test() : this(0, default, default, 0) { }
}
