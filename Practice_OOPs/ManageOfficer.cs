using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_OOPs
{
    internal class ManageOfficer
    {
        public List<Officer> Officers { get; set; }
        public ManageOfficer(List<Officer> Officers) {
                this.Officers = Officers;
        }
        public void AddOfficer(Officer Officer)
        {
            this.Officers.Add(Officer);
        }

        public List<Officer> SearchOfficerByName(String Name) {
            if (String.IsNullOrEmpty(Name)) return this.Officers;
            var result = Officers.FindAll(x => x.Name.ToLower().Contains(Name.ToLower()));
            if (!result.Any()) return new List<Officer>();
            return result;
        }

        public void ShowDetails ()
        {
            foreach ( Officer item in Officers)
            {
                item.Print();
            }
        }

    }
}
