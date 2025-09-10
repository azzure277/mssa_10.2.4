using System;
using System.Collections.Generic;
using System.Linq;

namespace mssa_10._2._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 55, 200, 740, 76, 230, 482, 95 };
            Console.WriteLine("The members of the list are :");
            foreach (var n in numbers)
            {
                Console.Write(n + " ");
            }
            Console.WriteLine("\nThe numbers greater than 80 are :");
            var result = numbers.Where(x => x > 80);
            foreach (var n in result)
            {
                Console.WriteLine(n);
            }
        }
    }
}
