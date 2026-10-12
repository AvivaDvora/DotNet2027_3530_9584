namespace DalApi;
using DO;

/// <summary>
/// ממשק שכבת הנתונים עבור ישות השאלה.
/// מגדיר את פעולות הגישה לנתוני השאלות (CRUD).
/// </summary>
public interface IQuestion: ICrud<Question>
{
    /// <summary>הוספת שאלה חדשה למאגר הנתונים.</summary>
    /// <param name="item">השאלה להוספה.</param>
    /// <exception cref="DalAlreadyExistsException">כאשר כבר קיימת שאלה עם אותו מזהה.</exception>
    int Create(Question item);

    /// <summary>החזרת שאלה לפי מזהה.</summary>
    /// <param name="id">מזהה השאלה המבוקשת.</param>
    /// <returns>השאלה שנמצאה, או <see langword="null"/> אם לא קיימת.</returns>
    Question? Read(int id);

    /// <summary>החזרת כל השאלות שבמאגר.</summary>
    /// <returns>רשימת השאלות.</returns>
    List<Question> ReadAll();

    /// <summary>עדכון נתוני שאלה קיימת לפי המזהה שלה.</summary>
    /// <param name="item">השאלה המעודכנת.</param>
    /// <exception cref="DalDoesNotExistException">כאשר לא קיימת שאלה עם מזהה כזה.</exception>
    void Update(Question item);

    /// <summary>מחיקת שאלה לפי מזהה.</summary>
    /// <param name="id">מזהה השאלה למחיקה.</param>
    /// <exception cref="DalDoesNotExistException">כאשר לא קיימת שאלה עם מזהה כזה.</exception>
    void Delete(int id);
}
