using System;

namespace myfarm
{
    class Program
    {

        static Dog[] puppy;
        static void CreateNewFarm()
        {
            //Dog dog1 = new Dog("Beagle", "Snoopy");
            //Dog dog2 = new Dog("Collie", "Lassie");

            //Dog puppy[] =
            puppy[0] = new Dog("Beagle", "Snoopy");
                puppy[1] = new Dog("Collie", "Lassie");
                puppy[2] = new Dog("Chihuahua", "Gidget");
                puppy[3] = new Dog("Mutt", "Yeller");
        }

        static void VisitFarm()
        {
            for (int i = 0; i < puppy.Length; i++)
            {
                Console.WriteLine($"{puppy[i].name} is a {puppy[i].breed} and is {puppy[i].age}");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("myfarm.Program.Main()");
            CreateNewFarm();
            VisitFarm();
        }
    }
}
