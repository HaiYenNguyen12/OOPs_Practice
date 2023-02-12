using Ex15.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Ex15.Management
{
    public class Management
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

        public void ShowAll(Department department)
        {
            foreach (var item in department.Students)
            {
                item.Print();
            }
        }

        public bool CheckFormalStudent(Student Student)
        {
            bool res = Student.GetType().Equals(typeof(FormalStudent)) ? true : false;

            return res;
        }

        public IEnumerable<double> GetAvgPoints(string Semester, Department department)
        {
            foreach (var i in department.Students)
            {
                foreach (var item in i.Results)
                {
                    if (item.SemesterName.Equals(Semester))
                    {
                        yield return item.AvgPoint;
                    }
                }
            }
        }

        public int CountNumberOfFormalStudent(Department Department)
        { 
            return  Department.Students.Where(x => x.GetType().Equals(typeof(FormalStudent))).Count();
        }

        public Student HighestEntryPoint(Department Department)
        {
            int maxPoint = Department.Students.Max(x => x.EntryPoint);
            return Department.Students.Where(x => x.EntryPoint == maxPoint).OrderBy(x=>x.FullName).First();
        }
           
        public List<InServiceStudent> GetInServiceStudents (string StudyPlace, Department Department)
        {
            var res = Department.Students.Where(x => x.GetType().Equals(typeof(InServiceStudent))).Cast<InServiceStudent>().Where(y => y.StudyPlace.Equals(StudyPlace)).ToList();
            if(res == null)
            {
                return new List<InServiceStudent>();
            }
            return res;
        }

        public List<Student> GetAllStudentsHigherThanEight(Department department)
        {
            var res = department.Students.Where(x => x.Results.Last().AvgPoint > 8).ToList();
            if (res == null) return new List<Student>();
            return res;
        }
        public Student HighestAvgPoint(Department Department)
        {
            double maxPoint = Department.Students.Select(x => x.Results.Max(y => y.AvgPoint)).First();
            return  Department.Students.Where(x => x.Results.Max(y => y.AvgPoint) == maxPoint).First();
        }

        public void GroupByEntryYear(List<Student> students)
        {
            var groupByEntryYearQuery =
                from student in students
                group student by student.EntryYear into newGroup
                orderby newGroup.Key
                select newGroup;

            foreach (var nameGroup in groupByEntryYearQuery)
            {
                Console.WriteLine($"Key: {nameGroup.Key}");
                foreach (var student in nameGroup)
                {
                    Console.WriteLine($"\t{student.EntryYear}, {student.FullName}");
                }
            }
        }
    }
}