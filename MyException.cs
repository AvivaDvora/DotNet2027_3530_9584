using System;

public class IdNotFoundException : Exception
{
    public IdNotFoundException(string message)
        : base(message) { }
    public IdNotFoundException(string message, Exception innerException)
        : base(message, innerException) { }
}

public class IdExistException : Exception
{
    public IdExistException(string message)
        : base(message) { }
    public IdExistException(string message, Exception innerException)
        : base(message, innerException) { }
}
