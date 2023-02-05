using System;
using System.Net.Security;
using System.Reflection;
using Ex6;

public class Program
{
    public static void Main(string[] args)
    {

        List<Student> students = new List<Student>()
        {
            new Student(1,"Yen Nguyen",12,"QT","19TCLC_DT6"),
            new Student(2,"Han Dinh",23,"DN","19TCLC_DT5"),
            new Student(3,"An Dinh",20,"QN","19TCLC_DT4"),

        };
        School obj = new School(students);
        Student new_student = new Student(4,"Jennie BlackPink", 20, "QT", "19TCLC_DT6");

        Console.WriteLine("List Student-------------------------List Student");
        obj.Add(new_student);
        foreach (Student student in students)
        {
            student.Print();
        }
        Console.WriteLine("20s-------------------------20s");

        List<Student> ages = obj.GetStudents20YearOlds();
        if(ages.Count > 0)
        {
            foreach (Student age in ages)
            {
                age.Print();
            }
        }
        else
        {
            Console.WriteLine("Nothing gonna show with 20 age-students");
        }
        Console.WriteLine("23s-------------------------DN");
        List<Student> ages23 = obj.CountStudentbyHometownAndOld();
        if (ages23.Count > 0)
        {
            foreach (Student age in ages23)
            {
                age.Print();
            }
            Console.WriteLine("Counted Number: " + ages23.Count.ToString());
        }
        else
        {
            Console.WriteLine("Nothing gonna show with 23 and Hometown in DN");
        }


    }
}
