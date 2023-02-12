using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    public class CandidateC : Candidate
    {
        public static readonly String VAN = "Van";
        public static readonly String SU = "Su";
        public static readonly String DIA = "Dia";
        public CandidateC(string Id, string Name, string Address, int Level) : base(Id, Name, Address, Level)
        {

        }
        public override void Print()
        {
            Console.WriteLine("ID:" + this.Id + " Name: " + this.Name + " Address: " + this.Address + " Level: " + this.Level.ToString() + " " + VAN + " " + SU + " " + DIA);
        }
    }
}
