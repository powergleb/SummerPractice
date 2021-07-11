using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class InvalidValueException : Exception
    {
        public InvalidValueException() : base()
        {
            // 
        }

        public InvalidValueException(string valueName)
            : base($"{valueName} has invalid value.")
        {
            //
        }
    }
}
