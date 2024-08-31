﻿namespace _05.SumEvenNumbers
{
    internal class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNum = numbers[i];

                if (currentNum % 2 == 0)
                {
                    sum += numbers[i];
                }
            }

            Console.WriteLine(sum);

        }
    }
}