using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
    internal class Family
    { 
        public List<Person> Persons { get; set; }

        public Family(List<Person> Persons) 
        {
            this.Persons = Persons;
        }
        public Family()
        {
            Persons = new List<Person>();
        }

        public void Print()
        {
          Console.WriteLine("The number of members in a family is: " + this.Persons.Count);
          foreach(Person person in Persons)
            {
                person.Print();
            }
        }
        public bool AddPerson(Person p)
        {
            var res = Persons.Where(x => x.Id.Equals(p.Id)).FirstOrDefault();
            if(res!= null)
            {
                return false;
            }
            this.Persons.Add(p);
            return true;
        }
    }
}
