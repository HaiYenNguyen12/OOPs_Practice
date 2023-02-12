using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    public class CandidateB : Candidate
    {
        public static readonly String SINH = "Sinh";
        public static readonly String LY = "Ly";
        public static readonly String HOA = "Hoa";
        public CandidateB(string Id, string Name, string Address, int Level) : base(Id, Name, Address, Level)
        {

        }
        public override void Print()
        {
            Console.WriteLine("ID: "+ this.Id + " Name: " + this.Name + " Address: " + this.Address + " Level: " + this.Level.ToString() + " " + SINH + " " + LY + " " + HOA);
        }
    }
}
