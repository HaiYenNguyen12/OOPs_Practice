using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex7
{
    internal class School
    {
        private List<Teacher> list;
        public School(List<Teacher> list)
        {
            this.list = list;
        }

        public bool AddTeacher(Teacher teacher)
        {
            if (list.Where(x => x.Id.Equals(teacher.Id)).Any()) {
                return false;
            }
            else
            {
                this.list.Add(teacher);
                return true;
            }

       
        }
        public bool RemoveTeacher(string id) 
        {
            if (String.IsNullOrEmpty(id)) return false;
            var teacher = list.Where(x => x.Id == id).Select(x => x).FirstOrDefault();

            if (teacher == null) return false;

            this.list.Remove(teacher);
            return true;
        }

        public decimal CalulatorNetSalary(string id)
        {
            if (String.IsNullOrEmpty(id)) return 0;
            var teacher = list.Where(x => x.Id == id).Select(x => x).FirstOrDefault();

            if (teacher == null) return 0;

            return teacher.Salary + teacher.Bonus - teacher.Penalty;
        }

        public void ShowDetails()
        {
            foreach  (Teacher item  in list)
            {
                item.Print();
            }
        }
    }
}
