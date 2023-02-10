using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex15.Entity
{
    internal class FormalStudent : Student
    {
        public FormalStudent(int id, string fullName, DateTime dob, int entryYear, int entryPoint, List<Result> results) : base(id, fullName, dob, entryYear, entryPoint, results)
        {

        }

        public virtual void Print()
        {
            base.Print();
        }
    }
}
