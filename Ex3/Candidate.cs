using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    internal class Candidate
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int Level { get; set; }

        public Candidate(string Id, string Name, string Address, int Level)
        {
            this.Id = Id;
            this.Name = Name;
            this.Address = Address;
            this.Level = Level;
        }
        public virtual void Print()
        {
            Console.WriteLine("iD: " + this.Id + " " +" Name: " +this.Name + " Address: " + this.Address + " Level: " + this.Level.ToString());
            
        }
    }
}
