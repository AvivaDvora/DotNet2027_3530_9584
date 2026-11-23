using System;

namespace Dal
{
    // The DAL contract (DalApi / DO.DalExceptions) requires DalDoesNotExistException
    // and DalAlreadyExistsException - both inherit from DO.DalException.
    public class IdNotFoundException : DO.DalDoesNotExistException
    {
        public IdNotFoundException(string message)
            : base(message) { }
        public IdNotFoundException(string message, Exception innerException)
            : base(message, innerException) { }
    }

    public class IdExistException : DO.DalAlreadyExistsException
    {
        public IdExistException(string message)
            : base(message) { }
        public IdExistException(string message, Exception innerException)
            : base(message, innerException) { }
    }
}
