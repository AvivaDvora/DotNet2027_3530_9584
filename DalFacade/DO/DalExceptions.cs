namespace DO;

/// <summary>
/// חריגה בסיסית של שכבת הנתונים.
/// כל חריגות שכבת הנתונים יורשות ממנה, כך שניתן לתפוס אותן יחד.
/// </summary>
public class DalException : Exception
{
    /// <summary>בניית חריגה עם הודעה.</summary>
    /// <param name="message">תיאור החריגה.</param>
    public DalException(string message) : base(message) { }

    /// <summary>בניית חריגה עם הודעה וחריגה פנימית.</summary>
    /// <param name="message">תיאור החריגה.</param>
    /// <param name="innerException">החריגה שגרמה לחריגה זו.</param>
    public DalException(string message, Exception innerException) : base(message, innerException) { }
}

/// <summary>
/// חריגה המושלכת כאשר מנסים לגשת או לעדכן רשומה שאינה קיימת במאגר הנתונים.
/// </summary>
public class DalDoesNotExistException : DalException
{
    /// <summary>בניית חריגה עם הודעה.</summary>
    /// <param name="message">תיאור החריגה.</param>
    public DalDoesNotExistException(string message) : base(message) { }

    /// <summary>בניית חריגה עם הודעה וחריגה פנימית.</summary>
    /// <param name="message">תיאור החריגה.</param>
    /// <param name="innerException">החריגה שגרמה לחריגה זו.</param>
    public DalDoesNotExistException(string message, Exception innerException) : base(message, innerException) { }
}

/// <summary>
/// חריגה המושלכת כאשר מנסים להוסיף רשומה שכבר קיימת במאגר הנתונים.
/// </summary>
public class DalAlreadyExistsException : DalException
{
    /// <summary>בניית חריגה עם הודעה.</summary>
    /// <param name="message">תיאור החריגה.</param>
    public DalAlreadyExistsException(string message) : base(message) { }

    /// <summary>בניית חריגה עם הודעה וחריגה פנימית.</summary>
    /// <param name="message">תיאור החריגה.</param>
    /// <param name="innerException">החריגה שגרמה לחריגה זו.</param>
    public DalAlreadyExistsException(string message, Exception innerException) : base(message, innerException) { }
}
