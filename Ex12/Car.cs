using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex12
{
    internal class Car : Transportation
    {
        public int NumberOfSeat { get; set; }
        public string KindOfEngine { get; set; }

        public Car(int numberOfSeat, string kindOfEngine, int id, string producer, decimal price, string color, int year) : base(id,producer, price, color, year)
        {
            NumberOfSeat = numberOfSeat;
            KindOfEngine = kindOfEngine;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Number of seats: {this.NumberOfSeat.ToString()}, kind of engine : {this.KindOfEngine}");
        }
    }
}
