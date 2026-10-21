namespace DalApi;
using DO;
/// <summary>
/// ממשק שכבת הנתונים עבור ישות השאלה-לנבחן.
/// הישות מזוהה באמצעות מפתח משולב: מזהה תלמיד, מזהה מבחן ומזהה שאלה.
/// מגדיר את פעולות הגישה לנתונים (CRUD).
/// </summary>
public interface IQuestionForStudent : ICrud<QuestionForStudent>
{
    /// <summary>הוספת שאלה-לנבחן חדשה למאגר הנתונים.</summary>
    /// <param name="item">הרשומה להוספה.</param>
    /// <exception cref="DalAlreadyExistsException">כאשר כבר קיימת רשומה זהה באותו מפתח משולב.</exception>
    int Create(QuestionForStudent item);

    /// <summary>החזרת רשומת שאלה-לנבחן לפי המפתח המשולב.</summary>
    /// <param name="studentId">מזהה התלמיד.</param>
    /// <param name="testId">מזהה המבחן.</param>
    /// <param name="questionId">מזהה השאלה.</param>
    /// <returns>הרשומה שנמצאה, או <see langword="null"/> אם לא קיימת.</returns>
    QuestionForStudent? Read(int studentId, int testId, int questionId);

    /// <summary>החזרת כל רשומות השאלות-לנבחן שבמאגר.</summary>
    /// <returns>רשימת הרשומות.</returns>
    List<QuestionForStudent> ReadAll();

    /// <summary>עדכון רשומת שאלה-לנבחן קיימת לפי המפתח המשולב.</summary>
    /// <param name="item">הרשומה המעודכנת.</param>
    /// <exception cref="DalDoesNotExistException">כאשר לא קיימת רשומה עם מפתח משולב כזה.</exception>
    void Update(QuestionForStudent item);

    /// <summary>מחיקת רשומת שאלה-לנבחן לפי המפתח המשולב.</summary>
    /// <param name="studentId">מזהה התלמיד.</param>
    /// <param name="testId">מזהה המבחן.</param>
    /// <param name="questionId">מזהה השאלה.</param>
    /// <exception cref="DalDoesNotExistException">כאשר לא קיימת רשומה עם מפתח משולב כזה.</exception>
    void Delete(int studentId, int testId, int questionId);
}
