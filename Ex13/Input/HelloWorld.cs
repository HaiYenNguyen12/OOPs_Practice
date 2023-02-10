using Ex13.Entity;
using Ex13.Exps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex13.Input
{
    internal class HelloWorld
    {
        public HelloWorld()
        {

        }
        public void Intro()
        {
            Console.WriteLine("-----APP CONSOLE MANAGEMENT EMPLOYEE-----");
            Console.WriteLine("1.Add Entity");
            Console.WriteLine("2.Delete Employee By Id");
            Console.WriteLine("3.Find Employee By Type");
            Console.WriteLine("4.Show details");
            Console.WriteLine("5.Exit");
        }

        public int InputId()
        {
            Random rnd = new Random();
            return rnd.Next(100, 1000);
        }
    }
}
