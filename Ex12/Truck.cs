using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex12
{
    internal class Truck : Transportation
    {
        public int GravityLoad { get; set; }

        public Truck(int gravityLoad, int id, string producer, decimal price, string color, int year) : base(id, producer, price, color, year)
        {
            GravityLoad = gravityLoad;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Gravity Load: {this.GravityLoad.ToString()}");
        }
    }
}
