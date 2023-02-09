using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex13.Entity
{
    internal class Intern : Employee
    {
        // Intern and Employee has "Is-a" relationship

        public string Majors { get; set; }
        public string Semester { get; set; }
        public string UniversityName { get; set; }

        public Intern(string majors, string semester, string universityName , int id, string fullName, DateTime birthday, string phoneNumber, string employeeType, List<Certificate> list, string email) : base(id, fullName, birthday, phoneNumber, employeeType, list, email)
        {
            Majors = majors;
            Semester = semester;
            UniversityName = universityName;
        }
        public Intern(string majors, string semester, string universityName)
        {
            Majors = majors;
            Semester = semester;
            UniversityName = universityName;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Majors: {this.Majors}, Semester: {this.Semester}, UniversityName: {this.UniversityName}");
        }

        public void Print(Intern Intern)
        {
            Intern temp = Intern;
            Employee new_employee = (Employee)Intern;
            base.Edit(new_employee);
            Majors = temp.Majors;
            Semester = temp.Semester;
            UniversityName = temp.UniversityName;

        }

    }
}
