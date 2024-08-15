using System;
using System.Linq;

namespace _08.TriangleOfNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            for (int i = 1; i <= input; i++)
            {
                Console.WriteLine(string.Concat(Enumerable.Repeat($"{i} ", i)));
            }
        }
    }
}
