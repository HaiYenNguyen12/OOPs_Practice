using Ex11;
using System;
using System.Net.Security;
using System.Reflection;
using System.Reflection.Metadata;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Input the real part of a:");
        double a_real = double.Parse(Console.ReadLine());
        Console.WriteLine("Input the imaginary part of a:");
        double a_imaginary = double.Parse(Console.ReadLine());

        ComplexNumber a = new ComplexNumber(a_real, a_imaginary);


        Console.WriteLine("Input the real part of b:");
        double b_real = double.Parse(Console.ReadLine());
        Console.WriteLine("Input the imaginary part of b:");
        double b_imaginary = double.Parse(Console.ReadLine());

        ComplexNumber b = new ComplexNumber(b_real, b_imaginary);

        a.ShowComplexNumber();
        b.ShowComplexNumber();

        Console.WriteLine($"The sum of a and b is: {a.SumTwoComplexNumber(b).ShowComplexNumber().ToString()}");
        Console.WriteLine($"The mult of a and b is: {a.MultiplicationTwoComplexNumber(b).ShowComplexNumber().ToString()}");



    }
}