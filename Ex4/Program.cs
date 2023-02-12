using System.Security.Cryptography.X509Certificates;
using Ex4;

public class Program
{
    public static void Main(string[] args)
    {
        Person child1 = new Person("1", "Ng Yen", 20, "Student");
        Person child2 = new Person("2", "ng quang trieu", 20, "student");
        Person mother1 = new Person("3", "Hoang Le Huy", 10, "teacher");
        Person father1 = new Person("4", "Dinh Hoang Dat", 10, "teacher");

        Family f1 = new Family();
        if (f1.AddPerson(child1) && f1.AddPerson(child2) && f1.AddPerson(mother1) && f1.AddPerson(father1)) Console.WriteLine("Congrats!");
        else Console.WriteLine("Please try again!"); 
      
        List<Person> list2 = new List<Person>()
        {
            new Person("5", "Le Dai Hai", 10, "teacher"),
            new Person("6", "Huynh Ngoc Thinh", 10, "teacher")
        };
        Family f2 = new Family(list2);

        List<Person> list3 = new List<Person>()
        {
            new Person("7", "Teayeon", 10, "tiktoker"),
            new Person("8", "Yoonanie", 10, "cooker")
        };
        Family f3 = new Family(list3);
        Quarter qt = new Quarter();
        qt.AddFamily(f1);
        qt.AddFamily(f2);
        qt.AddFamily(f3);
        int number = 0;
        while (true)
        {
            do
            {
               Console.WriteLine("Please text your number...");
               number = int.Parse(Console.ReadLine());
            }
            while (number > qt.Families.Count || number <= 0);
            for (int i = 0; i < number; i++)
            {
               qt.Families[i].Print();
            }
            }
        }
}