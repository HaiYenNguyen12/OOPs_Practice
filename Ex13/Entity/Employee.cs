using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex13.Const;

namespace Ex13.Entity
{
    internal class Employee
    {

        

        // Employee and Certificate has "Has-a" relationship
        public int Id { get; set; }
        public string FullName { get; set; }
        public DateTime Birthday { get; set; }
        public string PhoneNumber { get; set; }
        public string EmployeeType { get; set; }
        public List<Certificate> Certificates { get; set; }

        public static int EmployeeCount = 0;
        public string  Email { get; set; }


        public Employee(int id, string fullName, DateTime birthday, string phoneNumber, string employeeType, List<Certificate> list, string email)
        {
            Id = id;
            FullName = fullName;
            Birthday = birthday;
            PhoneNumber = phoneNumber;
            EmployeeType = employeeType;
            Certificates = list;
            Email = email;
        }
        public Employee()
        {
            Id = 0;
            FullName = "HaiYenCutehotme";
            Birthday = DateTime.Now;
            PhoneNumber = "0977179458";
            EmployeeType = TypeEmployee.Experienced;
            Certificates = new List<Certificate>();
            Email = "girlmilk123@gmail.com";
        }

        public virtual void ShowInfo()
        {

            Console.WriteLine($"Id: {this.Id.ToString()}, FullName: {this.FullName}, Birthday: {this.Birthday.ToString()}, PhoneNumber: {this.PhoneNumber}, EmployeeType: {this.EmployeeType}, Email: {this.Email}");
            foreach  (Certificate i in Certificates)
            {
                i.Print();
            }
        }
        public virtual void Edit(Employee Employee)
        {
            FullName = Employee.FullName;
            Birthday = Employee.Birthday;
            PhoneNumber = Employee.PhoneNumber;
            EmployeeType = Employee.EmployeeType;
            Certificates = Employee.Certificates;
        }


    }

   
}
