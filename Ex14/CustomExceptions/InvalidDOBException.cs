using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex14.CustomExceptions
{
    public class InvalidDOBException :Exception
    {
        public InvalidDOBException()
        {

        }
        public InvalidDOBException(string DOB) : base($"Invalid Day Of Birth {DOB}")
        {

        }
    }
}
