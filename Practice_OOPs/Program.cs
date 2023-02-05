
using System.Net.Security;
using System.Reflection;
using Practice_OOPs;

public class Program
{
    public static void Main(string[] args)
    {
        List<Officer> officers = new()
        {
            new Engineer("Singing","Yen",10,"Female","HVT"),
            new Staff("Shipper","Milo",10,"Ha Noi", "Male")
        };
        ManageOfficer obj = new ManageOfficer(officers);

        while (true)
        {
            int hello = 0;
            do
            {
                Console.WriteLine("APPLICATION MANAGER OFFICER");
                Console.WriteLine("1.Add Officer");
                Console.WriteLine("2.Find officer by name");
                Console.WriteLine("3.Show details");
                Console.WriteLine("4.Exit");
                hello = int.Parse(Console.ReadLine());
            }
            while (hello != 1 && hello != 2 && hello != 3 && hello != 4);
         
            switch (hello)
            {
                case 1:
                    {
                        int bye = 0;
                        do
                        {
                            Console.WriteLine("CHOOSE ENTITY");
                            Console.WriteLine("1.Engineer");
                            Console.WriteLine("2.Worker");
                            Console.WriteLine("3.Staff");
                            bye = int.Parse(Console.ReadLine());
                        }
                        while (bye != 1 && bye != 2 && bye != 3);
                    switch (bye)
                    {
                            case 1:
                                Engineer item = new Engineer("IT", "Yen", 20, "Shahara", "Other");
                                obj.AddOfficer(item);
                                item.Print();
                                break;
                            case 2:
                                Worker misa =  new Worker (1, "Yen", 20, "h2t","Other" );
                                obj.AddOfficer(misa);
                                misa.Print();
                                break;
                            case 3:
                              
                                Staff nana = new Staff("Save the world", "Yen", 20, "Cal" , "Mafia");
                                obj.AddOfficer(nana);
                                nana.Print();
                                break;
                        default:
                                break;
                    }
                    break;
                    }
                case 2:
                    Console.WriteLine("Please text your name you want to find ....");
                    string name = Console.ReadLine();
                    var res = obj.SearchOfficerByName(name);
                    if (res.Count != 0)
                    {
                        foreach (var item in res)
                        {
                            item.Print();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Can't not find any officers with that name....");
                    }
                    break;
                case 3:
                    obj.ShowDetails();
                    break; 
                case 4:
                    return;
              

                default:
                    break;
            }
        }

    }
}