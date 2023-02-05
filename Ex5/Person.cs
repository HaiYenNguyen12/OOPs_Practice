using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5
{
    internal class Person
    {
        public string FullName { get; set; }
        public byte Age { get; set; }
        public string Id { get; set; }
        public Room Room { get; set; }
        public int NumberRent  { get; set; }

        public Person(string FullName, byte Age, string Id, Room Room, int NumberRent)
        {
            this.FullName = FullName;
            this.Age = Age;
            this.Id = Id;
            this.Room = Room;
            this.NumberRent = NumberRent;
        }

        public virtual void Print()
        {
            Console.WriteLine("Full name: " + this.FullName + " Age: " + this.Age.ToString() + " Id: " + this.Id + " Category Room: "+this.Room.Category + " Price: " + this.Room.Price.ToString());
        }
    }
}
