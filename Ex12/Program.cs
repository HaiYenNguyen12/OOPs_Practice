using System;
using System.Net.Security;
using System.Reflection;
using Ex12;

public class Program
{
    public static void Main(string[] args)
    {
        List<Transportation> transportations = new()
        {
            new Car(4,"Melo",123,"Toyota", 10000, "Green",2020),
            new Motor(12,124,"Honda",1021,"White",2019),
            new Truck(1202, 125,"Kia",123144,"Black",2018)
        };
        Management obj = new Management(transportations);

        while (true)
        {
            int hello = 0;
            do
            {
                Console.WriteLine("APPLICATION MANAGER TRANSPORTATION:");
                Console.WriteLine("1.Add Transportion");
                Console.WriteLine("2.Remove Transportation");
                Console.WriteLine("3.Find Transportation");
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
                            Console.WriteLine("CHOOSE TRANSPORTATION:");
                            Console.WriteLine("1.Motor");
                            Console.WriteLine("2.Car");
                            Console.WriteLine("3.Truck");
                            bye = int.Parse(Console.ReadLine());
                        }
                        while (bye != 1 && bye != 2 && bye != 3);
                        switch (bye)
                        {
                            case 1:
                                Motor item = new Motor(12, 130, "Honda", 1021, "White", 2019);
                                if (obj.AddTransportation(item))
                                     Console.WriteLine("Added a motor successfully");
                                else Console.WriteLine("Error! Please try again!");
                                item.Print();
                                break;
                            case 2:
                                Car misa = new Car(4, "Melo", 131, "Macda", 10000, "Green", 2020);
                                if (obj.AddTransportation(misa))
                                    Console.WriteLine("Added a car succesfully");
                                else Console.WriteLine("Error!Please try again!");
                                misa.Print();
                                break;
                            case 3:
                                Truck nana = new Truck(1202, 132, "Kia", 123144, "Black", 2018);
                                if (obj.AddTransportation(nana))
                                    Console.WriteLine("Added a truck successfully");
                                else Console.WriteLine("Error!Please try again!");
                                nana.Print();
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

                    var res = obj.RemoveTransportation(int.Parse(id));
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
                    int cloudy = 0;
                    do
                    {
                        Console.WriteLine("Choose condition to search:");
                        Console.WriteLine("1.Producer");
                        Console.WriteLine("2.Color");
                        cloudy = int.Parse(Console.ReadLine());

                    }
                    while (cloudy!=1 && cloudy!=2);
                    Console.WriteLine("Please input some text that you want to find....");
                    string name = Console.ReadLine();
                    switch (cloudy)
                    {
                        case 1:
                            var res1 = obj.SearchTransportationByProducer(name);
                            if(res1.Count() > 0)
                            {
                                foreach (var item in res1)
                                {
                                    item.Print();
                                }
                            }
                            else { Console.WriteLine("Nothing"); }
                            break;
                        case 2:
                            var res2 = obj.SearchTransportationByColor(name);
                            if (res2.Count() > 0)
                            {
                                foreach (var item in res2)
                                {
                                    item.Print();
                                }
                            }
                            else { Console.WriteLine("Nothing"); }
                            break;
                        default:
                            break;
                    }
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