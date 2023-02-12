using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex15.Entity
{
    public class Department
    {
        public string Name { get; set; }
        public List<Student> Students { get; set; }

        public Department(string name, List<Student> students)
        {
            this.Name = name;
            this.Students = students;
        }

        public void Print()
        {
            Console.WriteLine($"Department name: {this.Name}");
            foreach (var item in Students)
            {
                item.Print();
            }
        }
    }
}
