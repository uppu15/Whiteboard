using System;

namespace Homework6D
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Food dinner = new Food("Spaghetti");
            Food lunch = new Food();
            Food tomorrowBreakfast = new Food("eggs");
            Food tomorrowLunch = new Food("sushi");
            Food tomorrowDinner = new Food("");

            Console.WriteLine($"What's for lunch? {lunch.FoodName}");
            Console.WriteLine($"What's for dinner? {dinner.FoodName}");
            Console.WriteLine($"What's for tomorrow breakfast? {tomorrowBreakfast.FoodName}");
            Console.WriteLine($"What's for tomorrow lunch? {tomorrowLunch.FoodName}");
            Console.WriteLine($"What's for tomorrow dinner? {tomorrowDinner.FoodName}");
        }
    }
}
