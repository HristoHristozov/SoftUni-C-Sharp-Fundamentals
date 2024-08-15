using System;

namespace _11.MultiplicationTable2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int theMulpiplicator = int.Parse(Console.ReadLine());
            int timesToMultiplicate = int.Parse(Console.ReadLine());

            if (timesToMultiplicate <= 10)
            {
                for (int i = timesToMultiplicate; i <= 10; i++)
                {
                    Console.WriteLine($"{theMulpiplicator} X {i} = {theMulpiplicator*i}");
                }
            }

            else Console.WriteLine($"{theMulpiplicator} X {timesToMultiplicate} = {theMulpiplicator*timesToMultiplicate}");

        }
    }
}
