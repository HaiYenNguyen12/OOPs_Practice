
using System.Net.Security;
using System.Reflection;
using System.Reflection.Metadata;
using Ex8;

public class Program
{
    public static void Main(string[] args)
    {
        Student a = new Student("Milo",20,"10A");
        Student b = new Student("Miloo", 21, "10B");
        Student c = new Student("Milooo", 22, "10C");

        List<Card> cards = new()
        {
            new Card(a,"123",10,5,1000),
            new Card(b,"124",10,5,1001),
            new Card(c,"125",10,5,1002),
        };
        Management obj = new Management(cards);

        while (true)
        {
            int hello = 0;
            do
            {
                Console.WriteLine("APPLICATION MANAGER BOOK");
                Console.WriteLine("1.Add new card");
                Console.WriteLine("2.Delete card by Id");
                Console.WriteLine("3.Show details");
                Console.WriteLine("4.Exit");
                hello = int.Parse(Console.ReadLine());
            }
            while (hello != 1 && hello != 2 && hello != 3 && hello != 4);

            switch (hello)
            {
                case 1:
                    {
                        Student d = new Student("Miloooo", 22, "10D");
                        Card new_card = new Card(d, "126", 3, 4,1009);
                        var restult = obj.AddCard(new_card);
                        if (restult) Console.WriteLine("Add successfully");
                        else Console.WriteLine("Please try again!");
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

                    var res = obj.RemoveCard(id);
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