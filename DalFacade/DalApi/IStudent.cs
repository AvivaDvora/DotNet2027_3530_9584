namespace DalApi;
using DO;
/// <summary>
/// ממשק שכבת הנתונים עבור ישות התלמיד (נבחן).
/// מגדיר את פעולות הגישה לנתוני התלמידים (CRUD).
/// </summary>
public interface IStudent : ICrud<Student>
{
    /// <summary>הוספת תלמיד חדש למאגר הנתונים.</summary>
    /// <param name="item">התלמיד להוספה.</param>
    /// <exception cref="DalAlreadyExistsException">כאשר כבר קיים תלמיד עם אותו מזהה.</exception>
    int Create(Student item);

    /// <summary>החזרת תלמיד לפי מזהה.</summary>
    /// <param name="id">מזהה התלמיד המבוקש.</param>
    /// <returns>התלמיד שנמצא, או <see langword="null"/> אם לא קיים.</returns>
    Student? Read(int id);

    /// <summary>החזרת כל התלמידים שבמאגר.</summary>
    /// <returns>רשימת התלמידים.</returns>
    List<Student> ReadAll();

    /// <summary>עדכון נתוני תלמיד קיים לפי המזהה שלו.</summary>
    /// <param name="item">התלמיד המעודכן.</param>
    /// <exception cref="DalDoesNotExistException">כאשר לא קיים תלמיד עם מזהה כזה.</exception>
    void Update(Student item);

    /// <summary>מחיקת תלמיד לפי מזהה.</summary>
    /// <param name="id">מזהה התלמיד למחיקה.</param>
    /// <exception cref="DalDoesNotExistException">כאשר לא קיים תלמיד עם מזהה כזה.</exception>
    void Delete(int id);
}
