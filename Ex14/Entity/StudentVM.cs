using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex14.Entity
{
    internal class StudentVM
    {
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public StudentVM(string fullName, string phoneNumber)
        {
            FullName = fullName;
            PhoneNumber = phoneNumber;
        }
    }
}
