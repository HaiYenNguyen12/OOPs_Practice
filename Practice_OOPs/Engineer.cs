using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_OOPs
{
    public class Engineer : Officer
    {
        public string Field { get; set; }
        public Engineer(string Field,string Name, int Age, string Gender, string Address) : base (Name,Age,Gender,Address)
        {
            this.Field = Field;
        }
        public override void Print()
        {
            Console.WriteLine(this.Name + " " + this.Gender + " " + this.Age.ToString() + " " + this.Address + " " +this.Field);
        }
    }
}
