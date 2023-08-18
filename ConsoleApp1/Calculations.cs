using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    internal class Calculations
    {
        public static void RunExample()
        {
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            ProcessData(list);
        }

        private static void ProcessData(List<int> data)
        {
            int sum = 0;
            int count = 0;
            int max = int.MinValue;
            int min = int.MaxValue;


            for (int i = 0; i < data.Count; i++)
            {
                sum += data[i];
                count++;
                if (data[i] > max)
                {
                    max = data[i];
                }
                if (data[i] < min)
                {
                    min = data[i];
                }
            }

            double average = (double)sum / count;

            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Average: " + average);
            Console.WriteLine("Max: " + max);
            Console.WriteLine("Min: " + min);


            if (average > 50)
            {
                Console.WriteLine("Above average!");
            }

            if (average < 50)
            {
                Console.WriteLine("Above average!");
            }

            if (count > 10)
            {
                Console.WriteLine("Large dataset!");
            }

            if (count > 10)
            {
                Console.WriteLine("Small dataset!");
            }

        }
    }
}
