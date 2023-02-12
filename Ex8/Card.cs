using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex8
{
    public class Card
    {
        public Student Student { get; set; }
        public string Id { get; set; }
        public int  LendDay { get; set; }
        public int  ReturnDay { get; set; }
        public int SerialNumber { get; set; }

        public Card(Student student, string id, int lendDay, int returnDay, int serialNumber)
        {
            Student = student;
            Id = id;
            LendDay = lendDay;
            ReturnDay = returnDay;
            SerialNumber = serialNumber;
        }

        public void Print()
        {
            Console.Write("Id: " + this.Id + " LendDay: " + this.LendDay + " ReturnDay : " + this.ReturnDay+ " Serial Number: " + this.SerialNumber.ToString() + " ");
            this.Student.Print();
        }
    }
}
