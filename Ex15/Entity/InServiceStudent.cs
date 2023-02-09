using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex15.Entity
{
    internal class InServiceStudent :Student
    {
        public string StudyPlace { get; set; }
        public InServiceStudent()
        {

        }
        public InServiceStudent(string studyPlace)
        {
            this.StudyPlace = studyPlace;
        }

        public InServiceStudent(string studyPlace, string id, string fullName, DateTime dob, int entryYear, int entryPoint, List<Result> results)
            : base(id, fullName, dob, entryYear, entryPoint, results)
        {
            this.StudyPlace = studyPlace;
        }

    }
}
