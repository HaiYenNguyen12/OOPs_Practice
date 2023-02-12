using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex13.Entity
{
    public class ExperiencedEmployee : Employee
    {
        // Experienced Employee and Employee has "Is-a" relationship

        public int ExpInYear { get; set; }
        public string ProSkill { get; set; }
        public ExperiencedEmployee(int exp, string skill, int id, string fullName, DateTime birthday, string phoneNumber, string employeeType, List<Certificate> list,string email) : base(id,fullName,birthday,phoneNumber,employeeType,list,email)
        {
            ExpInYear= exp;
            ProSkill= skill;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Exp year: {this.ExpInYear.ToString()}, ProSkill: {this.ProSkill}");
        }

        public void Edit(ExperiencedEmployee e)
        {
            ExperiencedEmployee temp = e;
            Employee new_employee = (Employee)e;
            base.Edit(new_employee);
            ExpInYear = temp.ExpInYear;
            ProSkill = temp.ProSkill;
        }
    }
}
