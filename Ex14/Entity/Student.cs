using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex14.Entity
{
    public class Student
    {
        public int Id { get; set; }
        public string  FullName { get; set; }
        public DateTime DayOfBirth { get; set; }
        public string Gender { get; set; }
        public string PhoneNumber { get; set; }
        public string UniversityName { get; set; }
        public string GradeLevel { get; set; }


        public Student(int id, string fullName, DateTime dob, string gender, string phone, string universityName, string level)
        {
            Id= id;
            FullName= fullName;
            DayOfBirth= dob;
            Gender=gender;
            PhoneNumber= phone;
            UniversityName= universityName;
            GradeLevel= level;
        }

         public virtual void ShowInfo()
        {
             Console.WriteLine($"Id: {this.Id.ToString()}, FullName: {this.FullName}, DOB: {this.DayOfBirth.ToString()}, Gender: {this.Gender}, Phone: {this.PhoneNumber}, University Name: {this.UniversityName}, Grade Level: {this.GradeLevel}");
        }

    }
}
