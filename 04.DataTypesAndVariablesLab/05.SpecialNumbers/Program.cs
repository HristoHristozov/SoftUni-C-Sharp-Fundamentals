﻿namespace _05.SpecialNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numRange = int.Parse(Console.ReadLine());


            for (int i = 1; i <= numRange; i++)
            {
                bool isSpecial = false;
                int number = i;
                int sum = 0;
                while (number != 0)
                {
                    int lastDigit = number % 10;
                    number /= 10;
                    sum += lastDigit;

                }

                if (sum == 5 || sum == 7 || sum == 11)
                {
                    isSpecial = true;
                }

                Console.WriteLine($"{i} -> {isSpecial}");
            }
            


        }
    }
}