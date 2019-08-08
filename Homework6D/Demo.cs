using System;
using System.Collections.Generic;
using System.Text;

namespace Homework6D
{
    public class Food
    {
        public string FoodName;
        private int numCaories;

        public Food()
        {
            this.FoodName = "tacos";
            this.numCaories = 350;
        }

        public Food(string Name)
        {
            this.FoodName = Name;
        }
        
        public Food(string Name, int Calories)
        {
            this.FoodName = Name;
            this.numCaories = Calories;
        }

        ~Food()
        {
            Console.WriteLine($"{this.FoodName} no longer exists.");
        }
    }
}
