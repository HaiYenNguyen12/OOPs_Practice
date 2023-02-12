using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5
{
    public class Hotel
    {
        private List<Person> persons;
        public Hotel(List<Person> list) 
        { 
            persons = list;
        }
        public void AddPerson(Person person)
        {
            var exist_person = this.persons.Where(x => x.Id.Equals(person.Id)).FirstOrDefault();
            if (exist_person == null)
            {
            this.persons.Add(person);
            }
            else
            {
            exist_person.NumberRent = person.NumberRent;
            exist_person.Room = new Room(person.Room.Category, person.Room.Price);
            }
        }

        public bool RemovePersonById(string Id)
        { 
            if (String.IsNullOrEmpty(Id)) return false;
            var person = persons.Where(x => x.Id == Id).Select(x=>x).FirstOrDefault();    

            if (person == null) return false;

            this.persons.Remove(person);
            return true;
        }

        public decimal CalculateRentalFee(string Id)
        {
            if (String.IsNullOrEmpty(Id)) return 0;
            var person = persons.Where(x => x.Id == Id).Select(x => x).FirstOrDefault();

            if (person == null) return 0;
            decimal fee = person.Room.Price * person.NumberRent;
            return fee;
        }

        public void ShowDetails ()
        {
            foreach (var person in persons)
            {
                person.Print();
            }
        }

    }
}
