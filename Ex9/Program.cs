
using System.Net.Security;
using System.Reflection;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting;
using Ex9;

public class Program
{
    public static void Main(string[] args)
    {
        Customer a = new Customer("BigBang", 36, 1218);
        //Customer b = new Customer("Tran Thi Hong Lan", 39, 1532);
        //Customer c = new Customer("Nguyen Hien Ai", 22, 3425);

        List<Customer> orangeJuice = new List<Customer>()
        {
            new Customer("Nguyen Van Tam", 36, 1212),
            new Customer("Tran Thi Hong Lan", 39, 1532),
            new Customer("Nguyen Hien Ai", 22, 3425)
        };
        Management obj = new Management(orangeJuice);

        List<Bill> new_bills = obj.CreateListBill(orangeJuice).ToList();

        obj.SetBills(new_bills);

        while (true)
        {
            int hello = 0;
            do
            {
                Console.WriteLine("APPLICATION MANAGER BILL");
                Console.WriteLine("1.Add a Customer");
                Console.WriteLine("2.Edit  a Customer");
                Console.WriteLine("3.Delete a Customer");
                Console.WriteLine("4.Create a new bill");
                Console.WriteLine("5.Edit a bill");
                Console.WriteLine("6.Delete a bill");
                Console.WriteLine("7.Show details bills");
                Console.WriteLine("8.Show details customers");
                Console.WriteLine("9.Exit");
                hello = int.Parse(Console.ReadLine());
            }
            while (hello != 1 && hello != 2 && hello != 3 && hello != 4 && hello != 5 && hello != 6 && hello != 7 && hello != 8 && hello != 9);

            switch (hello)
            {
                case 1:
                    {
                  
                        var result1 = obj.AddCustomer(a);
                        if (result1) Console.WriteLine("Add successfully");
                        else Console.WriteLine("Please try again!");
                        break;
                    }
                case 2:
                    var restult = obj.EditCustomer("Milooo_edited", 22, 1218);
                    if (restult) Console.WriteLine("Edit successfully");
                    else Console.WriteLine("Please try again!");
                    break;
                case 3:
                    string code = "";
                    do
                    {
                        Console.WriteLine("Please text your Code you want to delete ....");
                        code = Console.ReadLine();
                    }
                    while (string.IsNullOrEmpty(code));
                    if (obj.DeleteCustomer(int.Parse(code))) Console.WriteLine("Good Jobs!");
                    else Console.WriteLine("Sorrry! Please try again!");
                    break;
                case 4:
                    if (obj.CreateBill(123999, a)) Console.WriteLine("Created a bill successfully");
                    else Console.WriteLine("Nope! Nope!");
                    break;
                case 5:
                    string id = "";
                    do
                    {
                        Console.WriteLine("Please text your Code you want to edit....");
                        id = Console.ReadLine();
                    }
                    while (string.IsNullOrEmpty(id));
                    if (obj.EditBill(1, 11, int.Parse(id))) Console.WriteLine("The fee is: " + obj.CalculateFee(int.Parse(id)).ToString());
                    else Console.WriteLine("Not good! Please try again");
                    break;
                case 6:
                    string delete_id = "";
                    do
                    {
                        Console.WriteLine("Please text your Code you want to edit....");
                        delete_id = Console.ReadLine();
                    }
                    while (string.IsNullOrEmpty(delete_id));
                    if (obj.DeleteBill(int.Parse(delete_id))) Console.WriteLine("Good job");
                    else Console.WriteLine("Not good! Please try again");
                    break;
                case 7:
                    obj.ShowDetailsBill();
                    break;
                case 8:
                    obj.ShowDetailsCustomer();
                    break;
                case 9: 
                    return;

                default:
                    break;
            }
        }
    

    }
}