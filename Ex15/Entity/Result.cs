using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex15.Entity
{
    internal class Result
    {
        public string  SemesterName { get; set; }
        public int AvgPoint { get; set; }
        public Result(string semesterName, int avgPoint)
        {
            SemesterName = semesterName;
            AvgPoint = avgPoint;
        }

        public void Print()
        {

        }
    }

   
}
