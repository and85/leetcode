using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            CuttingRod cr = new CuttingRod();
            int[] price = { 3, 5, 8, 9, 10, 20, 22, 25 };
            int r = cr.recursiveMaxValue(price, 8);

            Console.WriteLine(r);

            Console.ReadLine();
        }
    }
}
