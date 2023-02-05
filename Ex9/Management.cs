using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex9
{
    internal class Management
    {
        private List<Bill> bills;
        private List<Customer> customers;
        Random rnd = new Random();

        public Management(List<Bill> bills, List<Customer> customers)
        {
            this.bills = bills;
            this.customers = customers;
        }

        public Management(List<Customer> customers)
        {
            this.customers = customers;
            this.bills = new List<Bill>();
        }

        public void SetBills(List<Bill> list)
        {
            this.bills = list;
        }
        //----------Management Bill-----------
        public bool CreateBill(int id, Customer new_customer)
        {
            if (bills.Where(x => x.Id == id).Any())
            {
                return false;
            }
            //Customer new_customer = new Customer(fullName, numberAddress, code);
            Bill bill = new Bill(id, 0, 0, new_customer);
            bills.Add(bill);
            return true;
        }
        public bool EditBill(int old_num, int new_num, int id)
        {
            if (bills.Where(x => x.Id == id).Any())
            {
                var item = bills.Where(x => x.Id == id).Select(x => x).First();
                item.OldNumber = old_num;
                item.NewNumber = new_num;
                return true;
            }
            return false;
        }

        public bool DeleteBill(int id)
        {
            if (bills.Where(x => x.Id == id).Any())
            {
                var item = bills.Where(x => x.Id == id).Select(x => x).First();
                bills.Remove(item);
                return true;
            }
            return false;

        }

        public decimal CalculateFee (int id)
        {

            if (bills.Where(x => x.Id == id).Any())
            {
                var item = bills.Where(x => x.Id == id).Select(x => x).First();
                item.Fee = (item.NewNumber - item.OldNumber) * 5;
                return item.Fee;
            }

            else return -1;

        }

        public IEnumerable<Bill> CreateListBill(List<Customer> customers)
        {
            int start = rnd.Next(100, 1000);
            foreach (var i in customers)
            {
                bool check = this.CreateBill(start, i);
               
                if (check)
                {
                    var res = bills.Where(x => x.Id == start).First();
                    start++; 
                    yield return res;
                }
            }
        }
        public void ShowDetailsBill()
        {
            foreach (var item in bills)
            {
                item.Print();
            }
        }

        //---------------------Management Customer-----------------
        public bool AddCustomer(Customer new_customer)
        {
            if (customers.Where(x => x.Code == new_customer.Code).Any())
            {
                return false;
            }
            this.customers.Add(new_customer);
            return true;
        }
        public bool EditCustomer(string fullName, int numberAddress, int code)
        {
            var res = customers.Where(x => x.Code == code).FirstOrDefault();
            if (res == null) return false;
            res.FullName = fullName;
            res.NumberAddress = numberAddress;
            return true;
        }

        public bool DeleteCustomer(int code)
        {
            var res = customers.Where(x => x.Code == code).FirstOrDefault();
            if (res != null)
            {
                customers.Remove(res);
                return true;
            }
            return false;
        }

        public void ShowDetailsCustomer()
        {
            foreach (var item in customers)
            {
                item.Print();
            }
        }

    }
}
