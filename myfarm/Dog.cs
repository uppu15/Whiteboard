using System;
using System.Collections.Generic;
using System.Text;

namespace myfarm
{
    public class Dog : Animal
    {
        static int MAX_DOG_AGE = 18;
        static Random R = new Random();
        public string breed;
        public string name;

        public Dog(string type, string name)
        {
            this.name = name;
            this.breed = type;
            this.age = R.Next(MAX_DOG_AGE);
        }
    }
}
