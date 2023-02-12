using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex7
{
    public class Teacher
    {
        public string FullName { get; set; }
        public int Age { get; set; }
        public string Id { get; set; }
        public string ClassName { get; set; }
        public decimal Salary { get; set; }
        public decimal Bonus { get; set; }
        public decimal Penalty { get; set; }
        public decimal NetSalary { get; set; }

        public Teacher(string fullname, int age, string id, string classname, decimal salary, decimal bonus, decimal penalty)
        {
            FullName = fullname;
            Age = age;
            Id = id;
            ClassName = classname;
            Salary = salary;
            Penalty = penalty;
            Bonus = bonus;
            NetSalary = bonus + salary - penalty;
        }
        public void Print()
        {
            Console.WriteLine("Full name: " + this.FullName + " Age: " + this.Age.ToString() + " Id: " + this.Id + "  " + " Class Name: " + this.ClassName);
        }



    }
}
