using System.Net.Security;
using System.Reflection;
using System.Reflection.Metadata;
using Ex10;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Please Input some Text: ");
        string new_string = Console.ReadLine();
        if(string.IsNullOrEmpty(new_string))
        {
            new_string = "Banana banana    banana : banana banana.";
        }
        Doc obj = new Doc(new_string);
        Console.WriteLine($"Count the number of words in a document: {obj.CountWords().ToString()}");
        Console.WriteLine($"Count the 'A' or 'a' letter in a document: {obj.CountALetter().ToString()}");
        Console.WriteLine($"Format the document: {obj.FormatDocs()}");


    }
}