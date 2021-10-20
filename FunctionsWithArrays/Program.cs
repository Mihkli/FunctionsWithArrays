using System;

namespace FunctionsWithArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] colors = { "red", "blue", "green" };
            string randomcolor = Pickrandomcolor(colors);
            DisplayRandomColor(colors);
            Console.WriteLine($"Arvuti valis {randomcolor}.");
        }

        private static int GenerateRandomNumberForArray(string[] someArray)
        {
            Random rnd = new Random();
            return rnd.Next(0, someArray.Length);
            
        }


        private static string Pickrandomcolor(string[] someArray)
        {
            

            return someArray[GenerateRandomNumberForArray(someArray)];
        }



        private static void DisplayRandomColor(string[] someArray)
        {
           

            Console.WriteLine(someArray[GenerateRandomNumberForArray(someArray)]);
        }

    }

}
