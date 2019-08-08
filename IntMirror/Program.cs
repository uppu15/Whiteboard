using System;

namespace IntMirror
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine(IntegerMirror(1234));
            //Console.WriteLine(IntegerMirror1(1234));
        }

        //public static int IntegerMirror1(int foward)
        //{
        //    int backward = 0;
        //    int temp;
        //    int temp2 =foward;

        //    for (int i = 5; i >= 0; i--)
        //    {

        //        temp = temp2 / (int)Math.Pow(10, i);
        //        temp2 = foward - (temp * (int)Math.Pow(10,i));

        //        backward += temp;/* / (int)Math.Pow(10, i);*/
        //    }

        //    return backward;
        //}

        public static int IntegerMirror(int n)
        {
            int foward =n;
            int remainder = 0;
            int backward = 0;
            while (foward > 0)
            {
                remainder = foward % 10;
                backward = backward * 10 + remainder;
                foward = foward / 10;  //left = Math.floor(left / 10); 
            }

            return backward;
        }

        public static int Reverse(int x)
        {
            //bool isNeg = (x < 0);
            int sum = 0;

            //x *= isNeg ? -1 : 1;
            //if (isNeg)
            //{
            //    x *= -1;
            //}
            while(x != 0)
            {
                sum *= 10;
                int remainder = x % 10;
                sum += remainder;
                x /= 10;
            }

            //if(isNeg)
            //{
            //    sum *= -1;
            //}
            return sum;
        }
    }
}
