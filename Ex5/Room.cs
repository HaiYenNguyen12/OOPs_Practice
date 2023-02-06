using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5
{
    internal class Room
    {
        public string Category { get; set; }
        public int Price { get; set; }


        public Room(string category, int price)
        {
            Category = category;
            Price = price;
        }

        public void Print()
        {
            Console.WriteLine("Category: " + this.Category + " Price: " + this.Price.ToString());
        }
    }
}
