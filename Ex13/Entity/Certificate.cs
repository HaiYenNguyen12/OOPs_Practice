using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex13.Entity
{
    public class Certificate
    {
        public int Id { get; set; }
        public string  Name { get; set; }
        public string Rank { get; set; }
        public DateTime Date { get; set; }
        public Certificate()
        {

        }
        public Certificate(int id, string name, string rank, DateTime date)
        {
            Id = id;
            Name = name;
            Rank = rank;
            Date = date;
        }
        public void Print()
        {
            Console.WriteLine($"Id: {this.Id.ToString()}, Name: {this.Name}, Rank: {this.Rank}, Date: {this.Date.ToString()}");
        }
    }
}
