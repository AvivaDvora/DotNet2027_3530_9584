namespace DalApi;
using DO;

/// <summary>
/// ממשק שכבת הנתונים עבור ישות התשובה.
/// מגדיר את פעולות הגישה לנתוני התשובות (CRUD).
/// </summary>
public interface IAnswer : ICrud<Answer>
{
    /// <summary>הוספת תשובה חדשה למאגר הנתונים.</summary>
    /// <param name="item">התשובה להוספה.</param>
    /// <exception cref="DalAlreadyExistsException">כאשר כבר קיימת תשובה עם אותו מזהה.</exception>
    void Add(Answer item);

    /// <summary>החזרת תשובה לפי מזהה.</summary>
    /// <param name="id">מזהה התשובה המבוקשת.</param>
    /// <returns>התשובה שנמצאה, או <see langword="null"/> אם לא קיימת.</returns>
    Answer? Read(int id);

    /// <summary>החזרת כל התשובות שבמאגר.</summary>
    /// <returns>רשימת התשובות.</returns>
    List<Answer> ReadAll();

    /// <summary>עדכון נתוני תשובה קיימת לפי המזהה שלה.</summary>
    /// <param name="item">התשובה המעודכנת.</param>
    /// <exception cref="DalDoesNotExistException">כאשר לא קיימת תשובה עם מזהה כזה.</exception>
    void Update(Answer item);

    /// <summary>מחיקת תשובה לפי מזהה.</summary>
    /// <param name="id">מזהה התשובה למחיקה.</param>
    /// <exception cref="DalDoesNotExistException">כאשר לא קיימת תשובה עם מזהה כזה.</exception>
    void Delete(int id);
    ///<summary> הוספת תשובה</summary>
    int Create(Answer item);
}
