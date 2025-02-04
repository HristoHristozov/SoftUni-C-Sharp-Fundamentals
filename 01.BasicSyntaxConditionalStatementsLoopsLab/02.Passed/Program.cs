using System;

namespace _02.Passed
{
    internal class Program
    {
        static void Main()
        {
            var grade = double.Parse(Console.ReadLine());

            if (grade >= 3)
            {
                Console.WriteLine("Passed!");
            }
        }
    }
}
