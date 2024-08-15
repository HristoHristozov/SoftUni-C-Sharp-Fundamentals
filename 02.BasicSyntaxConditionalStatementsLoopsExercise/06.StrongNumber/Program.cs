using System;

namespace _06.StrongNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            int inputCopy = input;

            int sum = 0;
            while (inputCopy > 0)
            {
                int factotial = 1;
                int currentNum = inputCopy % 10;
                inputCopy /= 10;
                for (int i = 1; i <= currentNum; i++)
                {
                    factotial *= i;
                }
                sum += factotial;
            }

            if (sum == input)
            {
                Console.WriteLine("yes");
            }
            else Console.WriteLine("no");
        }
    }
}
