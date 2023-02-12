using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
    public class Quarter
    {
        public List<Family> Families { get; set; }

        public Quarter(List<Family> Families)
        {
            this.Families = Families;
        }
        public Quarter()
        {
            this.Families = new List<Family>();
        }

        public void AddFamily(Family family)
        {
            this.Families.Add(family);
        }
        public void Print()
        {
            foreach (var family in Families)
            {
                family.Print();
            }
        }
    }
}
