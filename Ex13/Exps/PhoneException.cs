using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex13.Exps
{
    internal class PhoneException : Exception
    {
        public PhoneException()
        {

        }

        public PhoneException(string Phone) : base($"Invalid phone number: {Phone}")
        {

        }
    }
}
