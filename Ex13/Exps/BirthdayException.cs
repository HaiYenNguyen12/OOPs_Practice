using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex13.Exps
{
    public class BirthdayException : Exception
    {
        public BirthdayException()
        {

        }

        public BirthdayException(string Birthday) : base($"Invalid birthday {Birthday}") 
        {

        }
    }
}
