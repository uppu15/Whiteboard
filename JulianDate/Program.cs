using System;

//put all programs working around calendar's namespace calendar so it is easy to call in the future
namespace JulianDate
{
    public class Julie
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            JulianDateCal(3, 1);
        }

        public static int JulianDateCal  (int month, int day)
        {
            int julian = 0;
            
            int[] months = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            for (int i = 0; i < month; i++)
            {
                julian += months[i];
            }
            //julian = months[month - 1] + day;
            julian += day;
            Console.WriteLine(julian);

            return julian;
        }
    }
}
