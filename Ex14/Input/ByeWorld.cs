using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex14.CustomExceptions;

namespace Ex14.Input
{
    public class ByeWorld
    {
        public ByeWorld()
        {

        }
        public void Intro()
        {
            Console.WriteLine("-----APP CONSOLE MANAGEMENT STUDENT-----");
            Console.WriteLine("1.Add Student");
            Console.WriteLine("2.Recruit Student");
            Console.WriteLine("3.Show details");
            Console.WriteLine("4.Sort by name and phone");
            Console.WriteLine("5.Exit");
        }
        public int InputId()
        {
            Random rnd = new Random();
            return rnd.Next(100, 1000);
        }

        public int InputGPA()
        {
            Random rnd = new Random();
            return rnd.Next(7, 11);
        }
        public int InputEng()
        {
            Random rnd = new Random();
            return rnd.Next(0, 990);
        }

        public int InputEntry()
        {
            Random rnd = new Random();
            return rnd.Next(0, 101);
        }
    }
}
