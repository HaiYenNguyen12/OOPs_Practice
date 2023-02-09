using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex15.Entity
{
    internal class Department
    {
        public string Name { get; set; }
        public List<Student> Students { get; set; }
    }
}
