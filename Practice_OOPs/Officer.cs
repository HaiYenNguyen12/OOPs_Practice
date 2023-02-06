using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_OOPs
{
    class Officer
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }

        public Officer(string Name, int Age, string Gender, string Address)
        {
            this.Name = Name;
            this.Age = Age;
            this.Gender = Gender;
            this.Address = Address;
        }
        public virtual void Print()
        {
            Console.WriteLine(this.Name + " " + this.Gender + " " + this.Age.ToString() + " " + this.Address);
        }

    }
}
