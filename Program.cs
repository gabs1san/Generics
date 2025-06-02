using System;
using System.Globalization;

namespace Generics
{
    class Program
    {
        public static void Main(string[] args)
        {
            PrintSerivce printService = new PrintSerivce();

            Console.Write("How many values?: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());  
                printService.AddValue(x);
            }

            printService.Print();
            Console.WriteLine("First: " + printService.Fisrt()); 
        }
    }
}