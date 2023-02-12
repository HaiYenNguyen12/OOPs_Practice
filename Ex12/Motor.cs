using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex12
{
    public class Motor : Transportation
    {
        public int Power { get; set; }
        public Motor(int power, int id, string producer, decimal price, string color, int year) : base(id, producer, price, color, year)
        {
            Power = power;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Power : {this.Power.ToString()}");
        }
    }
}
