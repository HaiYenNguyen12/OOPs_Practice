using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex9
{
    internal class Bill
    {
        public int Id { get; set; }
        public int OldNumber { get; set; }
        public int NewNumber { get; set; }
        public Customer Customer { get; set; }
        public decimal Fee { get; set; }

        public Bill(int id, int oldNumber, int newNumber, Customer customer)
        {
            Id = id;
            OldNumber = oldNumber;
            NewNumber = newNumber;
            Customer = customer;
            Fee = (this.OldNumber - this.NewNumber) * 5;
        }


        public void Print()
        {
            Console.WriteLine("Id:"+ this.Id.ToString() +" Old number: " + this.OldNumber.ToString() + " New number: " + this.NewNumber.ToString() + " Fee: " + this.Fee.ToString());
        }
    }
}
