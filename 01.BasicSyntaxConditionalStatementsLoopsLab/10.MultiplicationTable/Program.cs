using System;

namespace _10.MultiplicationTable
{
    internal class Program
    {
        static void Main()
        {
            int theMultiplicator = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{theMultiplicator} X {i} = {theMultiplicator*i}");
            }
        }
    }
}
