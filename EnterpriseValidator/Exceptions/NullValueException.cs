using System;
namespace EnterpriseValidator.Exceptions
{
    public class NullValueException : Exception
    {
        public NullValueException(string? Message):base(Message)
        {

        }
    }
}
