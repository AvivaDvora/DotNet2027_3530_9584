namespace DO;

/// <summary>
/// ישות נתונים עבור שאלה הניתנת לנבחן במסגרת בחינה.
/// ישות זו מייצגת את היחס בין תלמיד לבין שאלה ספציפית במבחן, כולל התשובה שנבחרה.
/// </summary>
/// <param name="StudentId">מזהה התלמיד שהתבקש לענות על השאלה.</param>
/// <param name="TestId">מזהה המבחן שבו ניתנת השאלה.</param>
/// <param name="QuestionId">מזהה השאלה שניתנה.</param>
/// <param name="SelectedAnswerId">מזהה התשובה שנבחרה על ידי התלמיד.</param>
public record QuestionForStudent(int StudentId, int TestId, int QuestionId, int SelectedAnswerId)
{
    /// <summary>בנאי ריק - מיועד לצורך שימוש עתידי.</summary>
    public QuestionForStudent() : this(0, 0, 0, 0) { }
}
