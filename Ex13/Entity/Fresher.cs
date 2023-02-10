using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex13.Entity
{
    internal class Fresher : Employee
    {

        // Fresher and Employee has "Is-a" relationship

        public DateTime GraduationDate { get; set; }
        public string GraduationRank { get; set; }
        public string Education{ get; set; }

        public Fresher(DateTime graduationDate, string rank, string school, int id, string fullName, DateTime birthday, string phoneNumber, string employeeType, List<Certificate> list, string email) : base(id, fullName, birthday, phoneNumber, employeeType, list, email)
        {
            GraduationDate= graduationDate;
            GraduationRank= rank;    
            Education = school;
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"GraduationDate: {this.GraduationDate.ToString()}, GraduationRank : {this.GraduationRank}, EducationSchool: {this.Education}");
        }

        public void Print(Fresher Fresher)
        {
            Fresher temp = Fresher;
            Employee new_employee = (Employee)Fresher;
            base.Edit(new_employee);
            GraduationDate = temp.GraduationDate;
            GraduationRank = temp.GraduationRank;
            Education = temp.Education;
                
        }
    }
}
