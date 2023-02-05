using System.Net.Security;
using System.Reflection;
using Ex5;

public class Program
{
    public static void Main(string[] args)
    {
        RoomA a = new RoomA();
        RoomB b = new RoomB();
        RoomC c = new RoomC();
        List<Person> customers = new List<Person>()
        {
            new Person("Yen Nguyen", 10, "123",a,10),
            new Person("Ha Nguyen", 20, "124",b,10),
            new Person("Nam Nguyen", 30, "125",c,10),

        };
        Hotel obj = new Hotel(customers);

        while (true)
        {
            int hello = 0;
            do
            {
                Console.WriteLine("APPLICATION MANAGER HOTEL");
                Console.WriteLine("1.Add Customer");
                Console.WriteLine("2.Delete Customer By Id");
                Console.WriteLine("3.Calculator the rental fee for customer by Id");
                Console.WriteLine("4.Show details");
                Console.WriteLine("5.Exit");
                hello = int.Parse(Console.ReadLine());
            }
            while (hello != 1 && hello != 2 && hello != 3 && hello != 4 && hello!=5);

            switch (hello)
            {
                case 1:
                    {
                        int bye = 0;
                        do
                        {
                            Console.WriteLine("CHOOSE ROOM");
                            Console.WriteLine("1.RoomA");
                            Console.WriteLine("2.RoomB");
                            Console.WriteLine("3.RoomC");
                            bye = int.Parse(Console.ReadLine());
                        }
                        while (bye != 1 && bye != 2 && bye != 3);
                        switch (bye)
                        {
                            case 1:
                               Person nicetomeetyou =  new Person("Yen Nguyen", 10, "123", b, 10);
                                obj.AddPerson(nicetomeetyou);
                                nicetomeetyou.Print();
                                break;
                            case 2:
                                Person seeyoulater = new Person("Ha Nguyen", 20, "124", b, 10);
                                obj.AddPerson(seeyoulater);
                                seeyoulater.Print();
                                break;
                            case 3:

                                Person golbin = new Person("Nam Nguyen", 30, "125", c, 10);
                                obj.AddPerson(golbin); 
                                golbin.Print();
                                break;

                            default:
                                break;
                        }
                        break;
                    }
                case 2:
                    string id = "";
                    do
                    {
                        Console.WriteLine("Please text your Id you want to delete ....");
                        id = Console.ReadLine();
                    }
                    while (string.IsNullOrEmpty(id));
                 
                    var res = obj.RemovePersonById(id);
                    if (res)
                    {
                        Console.WriteLine("Deleled successfully");
                    }
                    else
                    {
                        Console.WriteLine("Sorry! Please try again!");
                    }
                    break;
                case 3:
                    string other_id = "";

                    do
                    {

                        Console.WriteLine("Please text your Id you want to calculate the fee....");
                        other_id = Console.ReadLine();
                    }

                    while (string.IsNullOrEmpty(other_id));

                    Console.WriteLine("The fee is: "+ obj.CalculateRentalFee(other_id).ToString());
                    break;

                case 4:
                    obj.ShowDetails();
                    break;
                case 5:
                    return;
                default:
                    break;
            }
        }

    }
}
