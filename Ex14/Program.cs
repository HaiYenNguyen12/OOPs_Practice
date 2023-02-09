using Ex14.CustomExceptions;
using Ex14.Entity;
using Ex14.Input;
using Ex14.Management;
using System.Numerics;
using System.Xml.Linq;

public class Program
{
    public static void Main(string[] args)
    {
        ByeWorld helloWorld = new ByeWorld();
        Management obj = new Management();

        while (true)
        {
            int hello = 0;
            do
            {
                helloWorld.Intro();
                hello = int.Parse(Console.ReadLine());
            }
            while (hello != 1 && hello != 2 && hello != 3 && hello != 4 && hello != 5);

            switch (hello)
            {
                case 1:
                    string name = "", phone = "", birthday = "";
                    DateTime t = new DateTime();
                    int id = helloWorld.InputId();
                    try
                    {
                        Console.WriteLine("Full name:");
                        name = Console.ReadLine();
                        Validation.ValidateFullName(name);

                    }
                    catch (InvalidFullNameException ex)
                    {
                        Console.WriteLine(ex.Message);
                        return;
                    }
                    t = new DateTime();
                    try
                    {
                        Console.WriteLine("Birthday: ");
                        birthday = Console.ReadLine();
                        Validation.ValidateBirthday(birthday);
                        t = DateTime.Parse(birthday).Date;
                    }
                    catch (InvalidDOBException e)
                    {
                        Console.Write(e.Message);
                        return;
                    }
                    catch (FormatException ex)
                    {
                        Console.Write(ex.Message);
                        return;
                    }
                    try
                    {
                        Console.WriteLine("Phone:");
                        phone = Console.ReadLine();
                        Validation.ValidatePhone(phone);
                    }
                    catch (InvalidPhoneNumberException ex)
                    {
                        Console.WriteLine(ex.Message);
                        return;
                    }
                    
                        int bye = 0;
                        do
                        {
                            Console.WriteLine("CHOOSE KIND OF STUDENT:");
                            Console.WriteLine("1.Good");
                            Console.WriteLine("2.Normal");
                            bye = int.Parse(Console.ReadLine());
                        }   
                        while (bye != 1 && bye != 2);
                        switch (bye)
                        {
                            case 1:
                                int GPA = helloWorld.InputGPA();
                                GoodStudent good = new GoodStudent(GPA, "MAMA award", id, name,t,"Female",phone,"DUT","Good");
                                bool check1 = obj.AddStudent(good);
                                if (check1) Console.WriteLine("Added sucessfully!");
                                else Console.WriteLine("Edited sucessfully!");
                                good.ShowInfo();
                                break;
                            case 2:
                                int EngPoint = helloWorld.InputEng();
                                int EntryPoint = helloWorld.InputEntry();
                                NormalStudent normal = new NormalStudent(EngPoint,EntryPoint, id,name,t,"Male",phone,"UEL", "Excellent");
                                bool check2 = obj.AddStudent(normal);
                                if (check2) Console.WriteLine("Added sucessfully!");
                                else Console.WriteLine("Edited sucessfully!");
                                normal.ShowInfo();
                                break;
                            default:
                                break;
                        }
                        break;

                case 2:
                    Console.WriteLine("Input the number you want to recruit");
                    int num = int.Parse(Console.ReadLine());
                    List<Student> students = obj.RecruitStudent(num);
                    foreach (Student student in students)
                    {
                        student.ShowInfo();
                    }
                    break;
                case 3:
                    obj.ShowAll();
                    break;
                case 4:
                    Console.WriteLine("Sort by fullname");
                    obj.SortByFullName();
                    Console.WriteLine("Sort by phone number");
                    obj.SortByPhoneNumber();
                    break;
                case 5:
                    return;
                default:
                    break;
            }
            }
        }
}