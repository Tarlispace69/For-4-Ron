using System;

namespace ConsoleApp3
{
    class Program
    {
        const int INPUTS = 25;
        const double AVG_AMOUNT = 3.0;

        static void Main(string[] args)
        {
            int i = 0, posAvgAmount = 0, avg = 0, j = 0;

            for (i = 0; i < 25; i++)
            {
                for (j=0; j < 3; j++)
                {
                    Console.WriteLine($"Enter a number: ");
                    avg += int.Parse(Console.ReadLine());
                }

                Console.WriteLine($"The average is: {avg / AVG_AMOUNT}");

                if (avg / AVG_AMOUNT > 0)
                {
                    posAvgAmount++;
                }
            }
            Console.WriteLine($"The amount of positive averages is: {posAvgAmount}");
            Console.ReadLine();
        }
    }
}
