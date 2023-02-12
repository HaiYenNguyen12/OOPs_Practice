using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex15.Entity
{
    public class Result
    {
        public string  SemesterName { get; set; }
        public double AvgPoint { get; set; }
        public Result(string semesterName, double avgPoint)
        {
            SemesterName = semesterName;
            AvgPoint = avgPoint;
        }

        public void Print()
        {
            Console.WriteLine($"Semester: {this.SemesterName}, AvgPoint: {this.AvgPoint.ToString()}");
        }
    }

   
}
