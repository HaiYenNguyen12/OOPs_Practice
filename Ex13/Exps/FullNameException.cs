using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex13.Exps
{
    internal class FullNameException : Exception
    {
        public FullNameException()
        {

        }
        public FullNameException(string Name) : base($"Invalid emoloyee name: {Name}")
        {

        }
    }
}
