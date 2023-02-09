using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ex13.Exps
{
    internal class Validation
    {
        public static void ValidateFullName(string FullName)
        {
            Regex regex = new Regex(@"^[a-zA-Z]+(?:[\s.]+[a-zA-Z]+)*$");

            if (!regex.IsMatch(FullName))
                throw new FullNameException(FullName);
        }

        public static void ValidatePhone(string Phone)
        {
            Regex regex = new Regex(@"^0[0-9]{9}$");
            if (!regex.IsMatch(Phone))
                throw new PhoneException(Phone);
        }

        public static void ValidateEmail(string Email)
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            if (!regex.IsMatch(Email))
                throw new EmailException(Email);
        }
        public static void ValidateBirthday(string Birthday) 
        {
            Regex regex = new Regex(@"(((0|1)[0-9]|2[0-9]|3[0-1])\/(0[1-9]|1[0-2])\/((19|20)\d\d))$");
            if (!regex.IsMatch(Birthday))
                throw new BirthdayException(Birthday);
        }
    }
}
