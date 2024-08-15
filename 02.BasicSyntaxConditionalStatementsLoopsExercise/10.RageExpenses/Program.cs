using System;
using System.Diagnostics.CodeAnalysis;

namespace _10.RageExpenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lostGamesCount = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice =  double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            double rageExpenses = 0.0;

            rageExpenses += (lostGamesCount / 2) * headsetPrice;
            rageExpenses += (lostGamesCount / 3) * mousePrice;
            rageExpenses += (lostGamesCount / 6) * keyboardPrice;
            rageExpenses += (lostGamesCount / 12) * displayPrice;


            Console.WriteLine($"Rage expenses: {rageExpenses:F2} lv.");
        }
    }
}
