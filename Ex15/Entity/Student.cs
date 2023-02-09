using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex15.Entity
{
    internal class Student
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public DateTime DayOfBirth { get; set; }
        public int EntryYear { get; set; }
        public int EntryPoint { get; set; }

        public List<Result> Results { get; set; }

        public Student()
        {

        }
        public Student(string id, string fullName, DateTime dob, int entryYear, int entryPoint, List<Result> results)
        {
            this.Id = Id;
            this.FullName = fullName;
            this.DayOfBirth = dob;
            this.EntryPoint = entryPoint;
            this.EntryYear = entryYear;
            this.Results = results;
        }

        public virtual void Print()
        {
            Console.WriteLine($"Id: {this.Id.ToString()}, Fullname: {this.FullName}, DoB: {this.DayOfBirth.Date.ToString()}, Entry point: {this.EntryPoint.ToString()}, Entry Year: {this.EntryYear.ToString()}"); 

        }

    }

  
}
