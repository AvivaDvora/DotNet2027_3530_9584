namespace DO;

/// <summary>
/// ישות נתונים עבור תלמיד (נבחן).
/// תלמיד משתייך למבחן מסוים ומקבל בו ציון.
/// </summary>
/// <param name="Id">מספר מזהה ייחודי של התלמיד.</param>
/// <param name="Name">שם התלמיד.</param>
/// <param name="TestId">מזהה המבחן שבו משתתף התלמיד.</param>
/// <param name="Score">הציון שקיבל התלמיד בבחינה.</param>
public record Student(int Id, string Name, int TestId, int Score)
{
    /// <summary>בנאי ריק - מיועד לצורך שימוש עתידי.</summary>
    public Student() : this(0, string.Empty, 0, 0) { }
}
