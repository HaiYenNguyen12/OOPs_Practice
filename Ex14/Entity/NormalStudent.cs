using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex14.Entity
{
    internal class NormalStudent : Student
    {
        public int EnglishScore { get; set; }
        public int EntryScore { get; set; }

        public NormalStudent(int englishScore, int entryScore, int id, string fullName, DateTime dob, string gender, string phone, string universityName, string level) : base(id, fullName, dob, gender, phone, universityName, level)
        {
            EnglishScore = englishScore;
            EntryScore = entryScore;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"English score: {this.EnglishScore.ToString()}, Entry Score: {this.EntryScore.ToString()}");
        }
    }
}
