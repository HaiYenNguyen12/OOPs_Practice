using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex12
{
    internal class Transportation
    {
        public int Id { get; set; }
        public string Producer { get; set; }
        public int Year { get; set; }
        public decimal  Price { get; set; }
        public string Color { get; set; }


        public Transportation(int id, string producer, decimal price, string color, int year)
        {
            Id = id;
            Producer = producer;
            Price = price;
            Color = color;
            Year = year;
        }

        public virtual void Print()
        {
            Console.WriteLine($"Id: {this.Id}, Producer: {this.Producer}, Year: {this.Year.ToString()}, Price: {this.Price.ToString()}, Color: {this.Color}");
        }
    }
}
