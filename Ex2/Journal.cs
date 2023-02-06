using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    internal class Journal : Document
    {
        public int SerialNumber { get; set; }
        public string Month { get; set; }


        public Journal(int SerialNumber, string Month, int Id, string PublisherName, int Number) : base(Id, PublisherName, Number)
        {
            this.SerialNumber = SerialNumber;
            this.Month = Month;
        }

        public override void Print()
        {
            Console.WriteLine(this.Id.ToString() + " " + this.Number.ToString() + " " + this.PublisherName + " " + this.SerialNumber.ToString() + " " + this.Month);
        }


    }
}
