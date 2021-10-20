using System;

namespace FunctionsReturns
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 20;
            int b = 25;

            int result = addtwonumbers(a, b);

            Console.WriteLine($"{a} + {b} = {result}");
        }

        private static int addtwonumbers(int x, int y)
        {
            return x + y;
        }
        
    }
}
