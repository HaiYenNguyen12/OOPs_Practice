using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex14.Entity
{
    internal class GoodStudent : Student
    {
        public double Gpa { get; set; }
        public string BestRewardName { get; set; }

        public GoodStudent(double gpa, string bestRewardName, int id, string fullName, DateTime dob, string gender, string phone, string universityName, string level) : base(id,fullName,dob, gender,phone,universityName,level)
        {
            Gpa = gpa;
            BestRewardName = bestRewardName;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();    
            Console.WriteLine($"GPA: {this.Gpa}, Best Reward Name: {this.BestRewardName}");
        }
    }
}
