using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    internal class Document
    {
        public int Id { get; set; }
        public String PublisherName { get; set; }
        public int Number { get; set; }
        public Document(int id, string publisherName, int number)
        {
            Id = id;
            PublisherName = publisherName;
            Number = number;
        }
        public virtual void Print()
        {
            Console.WriteLine(this.Id.ToString() + " " + this.PublisherName + " " + this.Number.ToString());
        }
    }
}
