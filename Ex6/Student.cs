using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6
{
    internal class Student
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public byte Age { get; set; }
        public string HomeTown { get; set; }
        public string ClassName { get; set; }

        public Student(int id, string fullName, byte age, string homeTown, string className)
        {
            Id = id;
            FullName = fullName;
            Age = age;
            HomeTown = homeTown;
            ClassName = className;
        }

        public void Print()
        {
            Console.WriteLine("Full name: " + this.FullName + " Age: " + this.Age + " Hometown: " + this.HomeTown + " className: " + this.ClassName);
        }
    }
}
