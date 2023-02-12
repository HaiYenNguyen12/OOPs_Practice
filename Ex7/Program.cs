
using System.Net.Security;
using System.Reflection;
using System.Reflection.Metadata;
using Ex7;

public class Program
{
    public static void Main(string[] args)
    {
        List<Teacher> teachers = new()
        {
            new Teacher("Jennie",20,"123","19TCLC_DT6", 10,10,5),
            new Teacher("Jisoo",20,"124","19TCLC_DT6", 10,10,5),
            new Teacher("Lisa",20,"125","19TCLC_DT6", 10,10,5),
        };
       School obj = new School(teachers);

        while (true)
        {
            int hello = 0;
            do
            {
                Console.WriteLine("APPLICATION MANAGER SCHOOL");
                Console.WriteLine("1.Add new teacher");
                Console.WriteLine("2.Delete teacher by Id");
                Console.WriteLine("3.Calculate the net salary");
                Console.WriteLine("4.Show details");
                Console.WriteLine("5.Exit");
                hello = int.Parse(Console.ReadLine());
            }
            while (hello != 1 && hello != 2 && hello != 3 && hello != 4 && hello != 5);

            switch (hello)
            {
                case 1:
                    {
                         Teacher roses = new Teacher("Jennie", 20, "126", "19TCLC_DT6", 10, 10, 5);
                        bool check = obj.AddTeacher(roses);
                        if(check)
                        {
                            Console.WriteLine("Well-done");
                        }
                        else
                        {
                            Console.WriteLine("The id exists. Please try again!!");
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

                    var res = obj.RemoveTeacher(id);
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

                        Console.WriteLine("Please text your Id you want to calculate the net salary....");
                        other_id = Console.ReadLine();
                    }

                    while (string.IsNullOrEmpty(other_id));
                    Console.WriteLine("The net salary is: " + obj.CalulatorNetSalary(other_id).ToString());
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