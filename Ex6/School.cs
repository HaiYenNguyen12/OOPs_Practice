using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ex6
{
    public class School
    {
        private List<Student> students;

        public School(List<Student> list)
        {
            this.students = list;
        }

        public bool Add(Student student)
        {
            if (this.students.Where(x => x.Id == student.Id).Count() > 0)
            {
                return false;
            }
            else
            {
                this.students.Add(student);
                return true;
            }
        }

        public List<Student> GetStudents20YearOlds() {
            var res = students.FindAll(x => x.Age == 20).ToList();
            if (res.Count > 0)
            {
                return res;
            }
            return new List<Student>();
        }

        public List<Student> CountStudentbyHometownAndOld()
        {
            var res = students.FindAll(x => x.Age == 23 && x.HomeTown.Equals("DN")).ToList();
            if (res.Count > 0)
            {
                return res;
            }
            return new List<Student>();
        }

    }
}
