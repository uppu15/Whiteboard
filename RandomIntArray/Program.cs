using System;

namespace RandomIntArray
{
    public class IntArray
    {

        public static int[] RandomIntArray()
        {
            return RandomIntArray(5);
        }

        public static int[] RandomIntArray(int numElements)
        {
            return RandomIntArray(numElements, 10);
        }

        public static int[] RandomIntArray(int numElements, int maxR)
        {
            Random r = new Random();

            int[] myIntArray = new int[numElements];

            for (int i = 0; i < numElements; i++)
            {
                myIntArray[i] = r.Next(maxR);
            }

            return myIntArray;
        }

        public static int GetMinValue(int[] myList)
        {
            //get smallest value in list
            int minListvalue = int.MaxValue;
            int minIndex = 0;

            for (int i = 0; i < myList.Length; i++)
            {
                if (myList[i] < minListvalue)
                {
                    minListvalue = myList[i];
                    minIndex = i;
                }
            }
            myList[minIndex] = int.MaxValue;
            return minListvalue;
        }

        public static int GetMaxValue(int[] myList)
        {
            int maxListValue = 0;

            //get highest value in list
            for (int i = 0; i < myList.Length; i++)
            {
                if (myList[i] >maxListValue)
                {
                    maxListValue = myList[i];
                }
            }
            return maxListValue;
        }

        public static int[] ArraySort(int[] unsortedList)
        {
            int[] sortedList = new int[unsortedList.Length];

            for (int i = 0; i < unsortedList.Length; i++)
            {
                sortedList[i] = GetMinValue(unsortedList);
            }

            return sortedList;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Whiteboard.RandomIntArray");

            int nrOfClasses = 6;
            int maxScore = 100;

            int[]myGrades = IntArray.RandomIntArray(nrOfClasses, maxScore);

            for (int i = 0; i < nrOfClasses; i++)
            {
                Console.WriteLine($"{i} : {myGrades[i]}");
            }
        }
    }
}
