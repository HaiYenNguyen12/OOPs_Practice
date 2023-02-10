using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex14.Entity;

namespace Ex14.Management
{
    internal class Management
    {
        private List<Student> students;
        public Management(List<Student> list)
        {
            this.students = list;
        }
        public Management()
        {
            students = new List<Student>();
        }

        public bool AddStudent(Student student)
        {
            if (students.Where(x => x.Id == student.Id).Any())
            {
                return false;
            }
            else
            {
                this.students.Add(student);
                return true;
            }
        }

        public void ShowAll()
        {
            foreach (var item in students)
            {
                item.ShowInfo();
            }
        }

        public List<Student> RecruitStudent(int num)
        {
            List<Student> list = new List<Student>();
            int count = students.Where(x => x.GetType() == typeof(GoodStudent)).Count();
            if (count > num)
            {
                var res = students.Where(x => x.GetType() == typeof(GoodStudent)).Cast<GoodStudent>().OrderBy(x => x.Gpa).ThenBy(y => y.FullName).ToList().Take(num);
                foreach (var item in res)
                {
                    list.Add(item);
                }
            }
            else if (count < num)
            {
                int remainder = num - count;
                var res1 = students.Where(x => x.GetType() == typeof(GoodStudent)).ToList();
                foreach (var item in res1)
                {
                    list.Add(item);
                }
                var res = students.Where(x => x.GetType() == typeof(NormalStudent)).Cast<NormalStudent>().OrderBy(x => x.EntryScore).ThenBy(y => y.EnglishScore).ThenBy(y => y.FullName).ToList().Take(remainder);
                foreach (var item in res)
                {
                    list.Add(item);
                }
            }
            else
            {
                var res = students.Where(x => x.GetType() == typeof(GoodStudent)).ToList();
                foreach (var item in res)
                {
                    list.Add(item);
                }
            }

            return list;
        }

        public void SortByFullName()
        {
            var newVM = new List<StudentVM>();
            foreach (var student in students)
            {
                var temp = new StudentVM(student.FullName, student.PhoneNumber);
                newVM.Add(temp);
            }
            SortByName hehe = new SortByName();
            newVM.Sort(hehe);

            foreach (var item in newVM)
            {
                Console.WriteLine($"Fullname: {item.FullName}, PhoneNumber: {item.PhoneNumber}");
            }
        }

        public void SortByPhoneNumber()
        {
            var newVM = new List<StudentVM>();
            foreach (var student in students)
            {
                var temp = new StudentVM(student.FullName, student.PhoneNumber);
                newVM.Add(temp);
            }
            SortByPhoneNumber hehe = new SortByPhoneNumber();
            newVM.Sort(hehe);

            foreach (var item in newVM)
            {
                Console.WriteLine($"Fullname: {item.FullName}, PhoneNumber: {item.PhoneNumber}");
            }
        }
    }
}
