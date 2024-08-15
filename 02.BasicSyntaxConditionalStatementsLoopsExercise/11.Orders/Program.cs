using System;

namespace _11.Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfOrders = int.Parse(Console.ReadLine());

            double allSum = 0.0;
            double sumLine = 0.0;

            for (int i = 1; i <= countOfOrders; i++)
            {
                double pricePerCapsule = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                double capsulesCount = double.Parse(Console.ReadLine());

                sumLine = (days * capsulesCount) * pricePerCapsule;
                Console.WriteLine($"The price for the coffee is: ${sumLine:F2}");
                allSum += sumLine;
                sumLine = 0;
            }

            Console.WriteLine($"Total: ${allSum:F2}");
        }
    }
}
