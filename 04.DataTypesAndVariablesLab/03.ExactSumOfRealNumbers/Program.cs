﻿namespace _03.ExactSumOfRealNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbersToEnter = int.Parse(Console.ReadLine());
            decimal sum = 0;
            for (int i = 1; i <= numbersToEnter; i++)
            {
                decimal input = decimal.Parse(Console.ReadLine());
                sum += input;
            }

            Console.WriteLine(sum);
        }
    }
}