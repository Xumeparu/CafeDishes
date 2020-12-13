using Cafe.Mealtime;
using System;
using System.Collections.Generic;
using System.Text;
using Cafe.Dishes.Main;
using Cafe.Dishes.Salad;
using Cafe.Dishes.Dessert;
using Cafe.Dishes.Drink;

namespace Cafe
{
    public class Cafe
    {
        private IMain main;
        private ISalad salad;
        private IDessert dessert;
        private IDrink drink;

        public Cafe(IMealtime mealtime)
        {
            main = mealtime.GetMain();
            salad = mealtime.GetSalad();
            dessert = mealtime.GetDessert();
            drink = mealtime.GetDrink();
        }

        public void GetMenu()
        {
            main.GetMain();
            salad.GetSalad();
            dessert.GetDessert();
            drink.GetDrink();
        }

        public static void WriteMenu(string timeOfDay)
        {
            switch (timeOfDay)
            {
                case "6:00":
                case "7:00":
                case "8:00":
                case "9:00":
                    Cafe breakfast = new Cafe(new Breakfast());
                    Console.WriteLine("\nMenu for Breakfast:");
                    breakfast.GetMenu();
                    break;
                case "12:00":
                case "13:00":
                case "14:00":
                case "15:00":
                    Cafe lunch = new Cafe(new Lunch());
                    Console.WriteLine("\nMenu for Lunch:");
                    lunch.GetMenu();
                    break;
                case "18:00":
                case "19:00":
                case "20:00":
                    Cafe supper = new Cafe(new Supper());
                    Console.WriteLine("\nMenu for Supper:");
                    supper.GetMenu();
                    break;
                default:
                    Console.WriteLine("\nUnfortunately, we can't offer you a menu at this time.");
                    break;
            }
        }
    }
}
