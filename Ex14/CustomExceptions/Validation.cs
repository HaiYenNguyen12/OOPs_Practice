using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ex14.CustomExceptions
{
    internal class Validation
    {
        public static void ValidateFullName(string FullName)
        {
            if (!(FullName.Length >= 10 && FullName.Length <= 50))
                throw new InvalidFullNameException(FullName);
        }

        public static void ValidatePhone(string Phone)
        {
            Regex regex = new Regex(@"^0[39][0158][0-9]{7}$");
            if (!regex.IsMatch(Phone))
                throw new InvalidPhoneNumberException(Phone);
        }
        public static void ValidateBirthday(string Birthday)
        {
            Regex regex = new Regex(@"(((0|1)[0-9]|2[0-9]|3[0-1])\/(0[1-9]|1[0-2])\/((19|20)\d\d))$");
            if (!regex.IsMatch(Birthday))
                throw new InvalidDOBException(Birthday);
        }
    }
}
