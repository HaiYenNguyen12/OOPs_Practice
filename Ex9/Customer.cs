using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex9
{
    internal class Customer
    {
        public string FullName { get; set; }
        public int NumberAddress { get; set; }
        public int Code { get; set; }

        public Customer(string fullName, int numberAddress, int code)
        {
            FullName = fullName;
            NumberAddress = numberAddress;
            Code = code;
        }
        public void Print()
        {
            Console.WriteLine("Full name : " + this.FullName + " Number Adress: "+ this.NumberAddress.ToString() + " Code: " + this.Code.ToString() + " ");
        }
    }
}
