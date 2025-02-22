namespace _05.Orders
{
    internal class Program
    {
        static void Main()
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            CalculateCost(product, quantity);
        }

        static void CalculateCost(string product, int quantity)
        {
            double price = 0.0;

            if (product == "coffee")
            {
                price = quantity * 1.5;
            }

            else if (product == "water")
            {
                price = quantity * 1;
            }

            else if (product == "coke")
            {
                price = quantity * 1.40;
            }

            else if (product == "snacks")
            {
                price = quantity * 2;
            }

            Console.WriteLine($"{price:F2}");
        }


    }
}