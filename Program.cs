using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Problem 6
            double fahrenheit, Celsuis;
            Console.WriteLine(" Enter the temprature in fahrenheit ");
            fahrenheit = int.Parse(Console.ReadLine());
            Celsuis = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine(" Temprature in celsuis is : " + Celsuis);
        }
    }
}
