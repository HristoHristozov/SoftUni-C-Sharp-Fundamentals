﻿namespace _03.RoundingNumbers
{
    internal class Program
    {
        static void Main()
        {
            double[] numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            int[] roundedNums = new int[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                roundedNums[i] = (int)Math.Round(numbers[i], MidpointRounding.AwayFromZero);
                Console.WriteLine($"{numbers[i]} => {roundedNums[i]}");
            }
        }
    }
}