using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    public class Enrollment
    {
        public List<Candidate> Candidates { get; set; }
        public Enrollment(List<Candidate> Candidates)
        {
           this.Candidates = Candidates;
        }
        public bool AddCandidate(Candidate Candidate)
        {
            if (this.Candidates.Where(x => x.Id.Equals(Candidate.Id)).Any())
            {
                return false;
            }
            this.Candidates.Add(Candidate);
            return true;
        }

        public List<Candidate> SearchOfficerById(string id)
        {
            if (String.IsNullOrEmpty(id)) return this.Candidates;
            var result = this.Candidates.FindAll(x => x.Id.Equals(id));
            if (!result.Any()) return new List<Candidate>();
            return result;

        }
        public void ShowDetails()
        {
            foreach (Candidate item in this.Candidates)
            {
                item.Print();
            }
        }
    }
}
