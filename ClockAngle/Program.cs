using System;

namespace ClockAngle
{
    public class Clock
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculate difference of angle between hour and minute.");

            

            Console.WriteLine($"{ClockAngleCal(12,01)}");
        }

        public static double ClockAngleCal(double hour, double minute)
        {
            
            double minuteAngle = minute * 6;
            double hourAngle = (hour * 30) + (minute * 0.5);
            if(hourAngle >= 360)
            {
                hourAngle = hourAngle - 360;
            }
            double diff = minuteAngle - hourAngle;
            if(diff < 0)
            {
                diff = diff * -1;
            }
            return diff;
        }
    }
}
