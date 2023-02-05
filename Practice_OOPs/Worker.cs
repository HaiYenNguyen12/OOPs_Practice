using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace Practice_OOPs
{
    class Worker : Officer
    {
        public int Level { get; set; }

        public Worker(int Level, string Name, int Age, string Address, string Gender) : base(Name, Age, Gender, Address)
        {
            this.Level= Level;
        }

        public override void Print()
        {
            Console.WriteLine(this.Name + " " + this.Gender + " " + this.Age.ToString() + " " + this.Address + this.Level.ToString());
        }
    }
}
