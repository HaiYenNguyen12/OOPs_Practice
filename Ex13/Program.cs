using Ex13.Const;
using Ex13.Entity;
using Ex13.Input;
using System.Reflection.Metadata;
using System.Xml.Linq;
using Ex13.Managements;
using Ex13.Exps;
using System.Security.Cryptography.X509Certificates;
using System.Numerics;

public class Program
{

    public static void Main(string[] args)
    {
        HelloWorld helloWorld = new HelloWorld();
        List<Certificate> list_certificates = new List<Certificate>
        {
            new Certificate(111,"Bachelor", "Excellent", DateTime.Now),
            new Certificate(112,"Master", "Excellent", DateTime.Now),
        };
        Management obj = new Management();

        while (true)
        {
            int hello = 0;
            do
            {
                helloWorld.Intro();
                hello = int.Parse(Console.ReadLine());
                Console.WriteLine(hello);
            }
            while (hello != 1 && hello != 2 && hello != 3 && hello != 4 && hello != 5);

            switch (hello)
            {
                case 1:
                    {
                        string name = "", phone = "", email = "", birthday = "";
                        DateTime t = new DateTime();
                        int id = helloWorld.InputId();
                        try
                        {
                            Console.WriteLine("Full name:");
                            name = Console.ReadLine();
                            Validation.ValidateFullName(name);
                        }
                        catch (FullNameException ex)
                        {
                            Console.WriteLine(ex.Message);
                            return;
                        }
                        try
                        {
                            Console.WriteLine("Email:");
                            email = Console.ReadLine();
                            Validation.ValidateEmail(email);
                        }
                        catch (EmailException ex)
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
                        catch (BirthdayException e)
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
                        catch (PhoneException ex)
                        {
                            Console.WriteLine(ex.Message);
                            return;
                        }
                        int bye = 0;
                        do
                        {
                            Console.WriteLine("CHOOSE KIND OF EMPLOYEE:");
                            Console.WriteLine("1.Exp");
                            Console.WriteLine("2.Intern");
                            Console.WriteLine("3.Fresher");
                            bye = int.Parse(Console.ReadLine());
                        }
                        while (bye != 1 && bye != 2 && bye != 3);
                        switch (bye)
                        {
                            case 1:
                                ExperiencedEmployee exp = new ExperiencedEmployee(10, "Dance", id, name, t, phone, TypeEmployee.Experienced, list_certificates, email);
                                bool check1 = obj.AddEmployee(exp);
                                if (check1) Console.WriteLine("Added sucessfully!");
                                else Console.WriteLine("Edited sucessfully!");
                                exp.ShowInfo();
                                break;
                            case 2:
                                Intern intern = new Intern("IT", "Semester 2", "DUT", id, name, t, phone, TypeEmployee.Intern, list_certificates, email);
                                bool check2 = obj.AddEmployee(intern);
                                if (check2) Console.WriteLine("Added sucessfully!");
                                else Console.WriteLine("Edited sucessfully!");
                                intern.ShowInfo();
                                break;
                            case 3:
                                Fresher fresher = new Fresher(DateTime.Now.Date, "Good", "UEL", id, name, t, phone, TypeEmployee.Fresher, list_certificates, email);
                                bool check3 = obj.AddEmployee(fresher);
                                if (check3) Console.WriteLine("Added sucessfully!");
                                else Console.WriteLine("Edited sucessfully!");
                                fresher.ShowInfo();
                                break;
                            default:
                                break;
                        }
                        break;
                    }
                case 2:
                    Console.WriteLine("Please write ID of the employee you want to delete....");
                    int id_del = int.Parse(Console.ReadLine());
                    bool res = obj.RemoveEmployee(id_del);
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
                    Console.WriteLine("Choose the type you want to see[Experienced,Intern,Fresher]...");
                    string type = Console.ReadLine();
                    bool result = obj.ShowEmployeeByType(type);
                    if (!result) { Console.WriteLine("Sorry! Please try again"); }
                    break;
                case 4:
                    obj.ShowEmployeeByType("");
                    break;
                case 5:
                    return;

                default:
                    break;
            }
        }

    }
}