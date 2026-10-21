namespace DalApi;
using DO;

/// <summary>
/// ממשק שכבת הנתונים עבור ישות המבחן.
/// מגדיר את פעולות הגישה לנתוני המבחנים (CRUD).
/// </summary>
public interface ITest : ICrud<Test>
{
    /// <summary>הוספת מבחן חדש למאגר הנתונים.</summary>
    /// <param name="item">המבחן להוספה.</param>
    /// <exception cref="DalAlreadyExistsException">כאשר כבר קיים מבחן עם אותו מזהה.</exception>
    int Create(Test item);

    /// <summary>החזרת מבחן לפי מזהה.</summary>
    /// <param name="id">מזהה המבחן המבוקש.</param>
    /// <returns>המבחן שנמצא, או <see langword="null"/> אם לא קיים.</returns>
    Test? Read(int id);

    /// <summary>החזרת כל המבחנים שבמאגר.</summary>
    /// <returns>רשימת המבחנים.</returns>
    List<Test> ReadAll();

    /// <summary>עדכון נתוני מבחן קיים לפי המזהה שלו.</summary>
    /// <param name="item">המבחן המעודכן.</param>
    /// <exception cref="DalDoesNotExistException">כאשר לא קיים מבחן עם מזהה כזה.</exception>
    void Update(Test item);

    /// <summary>מחיקת מבחן לפי מזהה.</summary>
    /// <param name="id">מזהה המבחן למחיקה.</param>
    /// <exception cref="DalDoesNotExistException">כאשר לא קיים מבחן עם מזהה כזה.</exception>
    void Delete(int id);
}
