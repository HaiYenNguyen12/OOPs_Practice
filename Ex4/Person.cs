using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
    public class Person
    {
        public string  Id { get; set; }
        public string  FullName { get; set; }
        public byte Age { get; set; }
        public string Job { get; set; }

        public Person(string Id, string FullName, byte Age, string Job)
        {
            this.Id = Id;
            this.FullName = FullName;
            this.Age = Age;
            this.Job = Job;
        }

        public void Print()
        {
            Console.WriteLine("ID: " + this.Id + " Name: " + this.FullName + " Age: " + this.Age.ToString() + " Job: " + this.Job); 
        }


    }
}
