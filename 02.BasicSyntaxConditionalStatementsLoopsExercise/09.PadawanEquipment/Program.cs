using System;
using System.Runtime.CompilerServices;

namespace _09.PadawanEquipment
{
    internal class Program
    {
        static void Main()
        {
            double moneyBalance = double.Parse(Console.ReadLine());
            double studentsCount = double.Parse(Console.ReadLine());
            double singleLightsaberPrice = double.Parse(Console.ReadLine());
            double singleRobePrice = double.Parse(Console.ReadLine());
            double singleBeltPrice = double.Parse(Console.ReadLine());

            double freeBelts = Math.Floor(studentsCount / 6);

            double sum = 0.0;

            sum = singleLightsaberPrice * (studentsCount + Math.Ceiling(studentsCount * 0.1)) + singleRobePrice * studentsCount + singleBeltPrice * (studentsCount - freeBelts);

            if (sum <= moneyBalance)
            {
                Console.WriteLine($"The money is enough - it would cost {sum:F2}lv.");
            }

            else if (sum > moneyBalance)
            {
                double balance = sum - moneyBalance;
                Console.WriteLine($"John will need {balance:F2}lv more.");
            }

        }
    }
}
