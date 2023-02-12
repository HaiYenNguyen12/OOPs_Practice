using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    public class Book : Document
    {
        public string AuthorName { get; set; }
        public int PageNumber { get; set; }

        public Book(string author_name, int page_number, int id, string publisherName, int number) : base(id, publisherName, number)
        {
            AuthorName= author_name;
            PageNumber = page_number;
        }

        public override void Print()
        {
            Console.WriteLine(this.Id.ToString() + " " + this.Number.ToString() + " " + this.PublisherName + " " + this.PageNumber.ToString() + " " + this.AuthorName);
        }
    }
}
