using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    internal class News : Document
    {
        [Range(1,31)]
        public int PublisherDay { get; set; }

        public News(int publisherDay, int id, string publisherName, int number) : base(id, publisherName, number)
        {
            PublisherDay= publisherDay;
        }

        public override void Print()
        {
            Console.WriteLine(this.Id.ToString() + " " + this.Number.ToString() + " " + this.PublisherName + " " + this.PublisherDay.ToString());
        }
    }
}
