using System.Net.Security;
using System.Reflection;
using Ex3;

public class Program
{
    public static void Main(string[] args)
    {
        List<Candidate> list = new()
        {
            new CandidateA("khoia","Nguyen", "Shahara", 1),
            new CandidateB("khoib","Hai", "Shahara", 1),
            new CandidateC("khoic","Yen", "Shahara", 1),
        };
        Enrollment obj = new Enrollment(list);

        while (true)
        {
            int hello = 0;
            do
            {
                Console.WriteLine("APPLICATION MANAGER CANDIDATE");
                Console.WriteLine("1.Add Candidate");
                Console.WriteLine("2.Find Candidate By Id");
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
                            Console.WriteLine("1.CandidateA");
                            Console.WriteLine("2.CandidateB");
                            Console.WriteLine("3.CandidateC");
                            bye = int.Parse(Console.ReadLine());
                        }
                        while (bye != 1 && bye != 2 && bye != 3);
                        switch (bye)
                        {
                            case 1:
                                CandidateA a = new CandidateA("1khoia", "Nguyen", "Shahara", 1);
                                bool res1 = obj.AddCandidate(a);
                                if (res1) Console.WriteLine("Added sucessfully");
                                else Console.WriteLine("Error! Please try again!");
                                a.Print();
                                break;
                            case 2:
                                CandidateB b = new CandidateB("1khoib", "Hai", "Shahara", 1);
                                bool res2 = obj.AddCandidate(b);
                                if (res2) Console.WriteLine("Added sucessfully");
                                else Console.WriteLine("Error! Please try again!");
                                b.Print();
                                break;
                            case 3:

                                CandidateC c = new CandidateC("1khoic", "Hai", "Shahara", 1);
                                bool res3 = obj.AddCandidate(c);
                                if (res3) Console.WriteLine("Added sucessfully");
                                else Console.WriteLine("Error! Please try again!");
                                c.Print();
                                break;
                            default:
                                break;
                        }
                        break;
                    }
                case 2:
                    Console.WriteLine("Please text your Id you want to find ....");
                    string id = Console.ReadLine();
                    var res = obj.SearchOfficerById(id);
                    if (res.Count != 0)
                    {
                        foreach (var item in res)
                        {
                            item.Print();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Can't not find any candidate with this id....");
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