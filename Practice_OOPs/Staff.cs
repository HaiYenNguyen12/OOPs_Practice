using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_OOPs
{
    internal class Staff : Officer
    {
        public string Mission { get; set; }
        public Staff(string Misson, string Name, int Age, string Address, string Gender) : base(Name, Age, Address, Gender)
        {
            this.Mission = Misson;
        }
        public override void Print()
        {
            Console.WriteLine(this.Name + " " + this.Gender + " " + this.Age.ToString() + " " + this.Address + " " +this.Mission);
        }
    }
}
