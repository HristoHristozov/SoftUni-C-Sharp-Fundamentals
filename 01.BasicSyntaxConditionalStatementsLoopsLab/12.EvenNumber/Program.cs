using System;

namespace _12.EvenNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isBool = false;
            while (!isBool)
            {
                int input = int.Parse(Console.ReadLine());

                if (!(input % 2 == 0))
                {
                    Console.WriteLine("Please write an even number.");
                }
                if (input % 2 == 0)
                {
                    Console.WriteLine($"The number is: {Math.Abs(input)}");
                    isBool = true;
                }

            }
        }
    }
}
