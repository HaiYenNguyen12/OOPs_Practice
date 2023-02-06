using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex8
{
    internal class Student
    {
        public string FullName { get; set; }
        public int Age { get; set; }
        public string ClassName { get; set; }

        public Student(string fullname, int age, string classname )
        {
            FullName = fullname;
            Age = age;
            ClassName = classname;
        }

        public void Print()
        {
            Console.WriteLine("Full name: " + this.FullName + " Age: " + this.Age.ToString()
            + " Class name: " + this.ClassName);
        }

    }
}
