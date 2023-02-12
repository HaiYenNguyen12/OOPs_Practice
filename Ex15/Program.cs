using System;
using System.Security.Cryptography.X509Certificates;
using Ex15.Entity;
using Ex15.Management;

public class Program
{
    public static void Main(string[] args)
    {
        List<Result> result1 = new List<Result>()
        {
            new Result("S1", 9),
            new Result("S2", 7)
        };

        List<Result> result2 = new List<Result>()
        {
            new Result("S1", 9),
            new Result("S2", 7),
            new Result("S3",8),
            new Result("S4",6)
        };

        List<Result> result3 = new List<Result>()
        {
            new Result("S1", 9),
            new Result("S2", 7),
            new Result("S3",9),
        };

        List<Result> result4 = new List<Result>()
        {
            new Result("S1", 9),
            new Result("S2", 7),
            new Result("S3",8),
            new Result("S4",6)
        };

        List<Student> students = new List<Student>()
        {
             new InServiceStudent("Da Nang",10,"Nguyen Hai Yen",DateTime.Parse("12/03/1997"),2019,10,result1),
             new InServiceStudent("Quang Nam",20,"Nguyen An Yen",DateTime.Parse("12/03/1997"),2020,9,result2),
             new FormalStudent(30,"Nguyen Kim Yen",DateTime.Parse("12/03/1997"),2021,8,result3),
             new FormalStudent(40,"Nguyen Thanh Yen",DateTime.Parse("12/03/1997"),2022,7,result4)
        };

        Department dep = new Department("IT", students);

        Management obj = new Management();

        Console.WriteLine("Show All Students:");

        obj.ShowAll(dep);

        Console.WriteLine("Check All Formal Student:");
        foreach (var i in dep.Students)
        {
            if (obj.CheckFormalStudent(i))
            {
                Console.WriteLine("Formal Student:");
                i.Print();
            }
        }

        Console.WriteLine("Get Avg Point of this Semester");
        List<double> hello = obj.GetAvgPoints("S1", dep).ToList();
        foreach (var i in hello)
        {
            Console.Write(i.ToString() + "---");
        }

        Console.WriteLine("\nCount the number of formal students:");
        Console.WriteLine(obj.CountNumberOfFormalStudent(dep));

        Console.WriteLine("Highest Entry Point is:");
        obj.HighestAvgPoint(dep).Print();

        Console.WriteLine("Get All In-Service Students:");
        var bye = obj.GetInServiceStudents("Quang Nam", dep);
        if (bye.Count > 0)
        {
            foreach (var i in bye)
            {
                i.Print();
            }
        }

        Console.WriteLine("Get all students have a point more than 8 in last semester:");
        var res2 = obj.GetAllStudentsHigherThanEight(dep);
        if (res2.Count > 0)
        {
            foreach (var i in res2)
            {
                i.Print();
            }
        }

        Console.WriteLine("Student has a highest avg point is: ");
        obj.HighestAvgPoint(dep).Print();

        Console.WriteLine("Group by entry year: ");
        obj.GroupByEntryYear(dep.Students);

    }
}