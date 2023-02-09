using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Ex14.CustomExceptions
{
    internal class InvalidPhoneNumberException :Exception
    {
        public InvalidPhoneNumberException()
        {

        }
        public InvalidPhoneNumberException(string Phone) : base($"Invalid phone number: {Phone}")
        {

        }
    }
}
