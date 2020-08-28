using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = runNFamilies(37000000);
            Console.WriteLine(result);
            Console.ReadLine();
        }

        static double runNFamilies(int n)
        {
            int boys = 0;
            int girls = 0;
            for (int i = 0; i < n; i++)
            {
                int[] genders = runOneFamily();
                girls += genders[0];
                boys += genders[1];
            }
            return girls / (double)(boys + girls);
        }

        static int[] runOneFamily()
        {
            Random random = new Random();
            int boys = 0;
            int girls = 0;
            while (girls == 0)
            { // until we have a gir l
                if (random.Next(100) > 50)
                {
                girls += 1;
                }
                else
                {
                    boys += 1;
                }
            }
            int[] genders = { girls, boys };
            return genders;
        }
    }
}
