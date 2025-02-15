using System;

namespace _06.EqualSum
{
    public class Program
    {
        static void Main()
        {
            int[] num = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            bool isFound = false;

            for (int i = 0; i < num.Length; i++)
            {
                int leftSum = 0;
                for (int k = 0; k < i; k++)
                {
                    leftSum += num[k];
                }

                int rightSum = 0;
                for (int j = num.Length - 1; j > i; j--)
                {
                    rightSum += num[j];
                }

                if (leftSum == rightSum && !isFound)
                {
                    Console.WriteLine(i);
                    isFound = true;
                }
            }

            if (!isFound)
            {
                Console.WriteLine("no");
            }

        }
    }
}