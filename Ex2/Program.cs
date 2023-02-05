
using System.Net.Security;
using System.Reflection;
using Ex2;

public class Program
{
    public static void Main(string[] args)
    {
        List<Document> docs = new()
        {
            new Book("Nguyen Nhat Anh",100,1,"NXB Tre",123),
            new News(12,2,"NXB Nha Nam",1234),
            new Journal(12345, "February",3,"NXB Kim Dong",123456)
        };
        ManageLibrary obj = new ManageLibrary(docs);

        while (true)
        {
            int hello = 0;
            do
            {
                Console.WriteLine("APPLICATION MANAGER LIBRARY");
                Console.WriteLine("1.Add new document");
                Console.WriteLine("2.Delete document by Id");
                Console.WriteLine("3.Find document by type");
                Console.WriteLine("4.Show details");
                Console.WriteLine("5.Exit");
                hello = int.Parse(Console.ReadLine());
            }
            while (hello != 1 && hello != 2 && hello != 3 && hello != 4 && hello!= 5);

            switch (hello)
            {
                case 1:
                    {
                        int bye = 0;
                        do
                        {
                            Console.WriteLine("CHOOSE KIND OF DOCUMENT:");
                            Console.WriteLine("1.Book");
                            Console.WriteLine("2.News");
                            Console.WriteLine("3.Journal");
                            bye = int.Parse(Console.ReadLine());
                        }
                        while (bye != 1 && bye != 2 && bye != 3);
                        switch (bye)
                        {
                            case 1:
                                Book item = new Book("To Hoai",100,4,"NXB Kim Dong",123);
                                bool check1 = obj.AddDocument(item);
                                if (check1 == true) Console.WriteLine("Added sucessfully!");
                                else Console.WriteLine("Error! Please try again!");
                                item.Print();
                                break;
                            case 2:
                                News misa = new News(12, 5, "NXB Nha Nam", 1235);
                                bool check2 = obj.AddDocument(misa);
                                if (check2 == true) Console.WriteLine("Added sucessfully!");
                                else Console.WriteLine("Error! Please try again!");
                                misa.Print();
                                break;
                            case 3:
                                Journal nana = new Journal(12349, "March", 6, "NXB Hong Kong", 123457);
                                bool check3 = obj.AddDocument(nana);
                                if (check3 == true) Console.WriteLine("Added sucessfully!");
                                else Console.WriteLine("Error! Please try again!");
                                nana.Print();
                                break;
                            default:
                                break;
                        }
                        break;
                    }
                case 2:
                    Console.WriteLine("Please write ID....");
                    int id = int.Parse(Console.ReadLine());
                    bool res = obj.RemoveOfficer(id);
                    if (res)
                    {
                        Console.WriteLine("Deleted successfully");
                    }
                    else
                    {
                        Console.WriteLine("Sorry! Please try again.");
                    }
                    break;
                case 3:
                    Console.WriteLine("Choose the type you want to see[book, journal,news]...");
                    string type = Console.ReadLine();
                    

                    
                    bool result = obj.SearchDocumentByType(type);
                    if (!result) { Console.WriteLine("Sorry! Please try again"); }
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