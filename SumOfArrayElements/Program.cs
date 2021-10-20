using System;

namespace SumOfArrayElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 125, 654, 532, 1246, 523413, 12, 6 };
            Console.WriteLine($"Sum of all elements: {SumOfElements(numbers)}");


        }

        private static int SumOfElements(int[] somearray)
        {
            int sum = 0;

            for(int i = 0; i < somearray.Length; i++)
            {
                sum = sum + somearray[i];
            }
            
            return sum;
        }

    }
}
