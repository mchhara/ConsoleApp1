using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    internal static class Linq1
    {
        public static void TestLinq()
        {
            List<int> ints = new List<int>() { 1, 2, 3, 4, 5 };
            Console.WriteLine($"ints = {string.Join(", ", ints)}");


            var ints2 = ints.Select(number =>
            {
                throw new Exception("ERROR");
                return number;
            });
            Console.WriteLine("saved ints to 2nd variable");


            var intsDescending = ints2.OrderByDescending(number => number);
            Console.WriteLine("Save ints as ordered desc");


            var descendingList = intsDescending.ToList();
            Console.WriteLine("Save ints to 2nd list");
        }
    }
}
