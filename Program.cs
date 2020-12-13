using System;
using Cafe.Mealtime;

namespace Cafe
{
    class Program
    {
        static void Main(string[] args)
        {
            string timeOfDay;
            Console.Write("Enter time, please: ");
            timeOfDay = Console.ReadLine();

            Cafe.WriteMenu(timeOfDay);
            
            Console.ReadKey();
        }
    }
}
