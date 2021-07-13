using System;


namespace Exceptions
{
    public class ValueAlreadyExistsException : Exception
    {
        public ValueAlreadyExistsException()
            : base("Value already exists.")
        {
            //
        }
    }
}
