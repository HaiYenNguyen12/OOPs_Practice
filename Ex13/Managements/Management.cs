using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex13.Entity;

namespace Ex13.Managements
{
    internal class Management
    {
        private List<Employee> list;
        public Management(List<Employee> list)
        {
            this.list = list;
        }
        public Management()
        {
            this.list = new List<Employee>();
        }
        public bool RemoveEmployee(int Id)
        {
            if (list.Where(x => x.Id == Id).Any())
            {
                var item = list.Where(x => x.Id == Id).First();
                list.Remove(item);
                return true;
            }
            return false;
        }

        public bool AddEmployee(Employee Employee)
        {
            if (list.Where(x => x.Id == Employee.Id).Any())
            {
                var res = list.Where(x => x.Id == Employee.Id).First();
                res.Edit(Employee);
                return false;
            }
            else
            {
                this.list.Add(Employee);
                return true;
            }
        }

        public bool ShowEmployeeByType(string Type)
        {
            if (string.IsNullOrEmpty(Type)) 
            {
                foreach (var item in list)
                {
                    item.ShowInfo();
                }
                return true;
            }
            var result = list.FindAll(x => x.EmployeeType.Equals(Type));
            if (result.Count != 0)
            {
                foreach (var item in result)
                {
                    item.ShowInfo();
                }
                return true;
            }
            return false;
        }

    }
}
