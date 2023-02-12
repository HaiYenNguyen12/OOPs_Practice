using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex14.CustomExceptions
{
    public class InvalidFullNameException : Exception
    {
        public InvalidFullNameException()
        {

        }

        public InvalidFullNameException(string FullName) : base($"Invalid fullname: {FullName}") 
        {

        }
    }
}
