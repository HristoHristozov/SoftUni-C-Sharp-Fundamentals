namespace _05.Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string product = Console.ReadLine();
            int productQuantity = int.Parse(Console.ReadLine());

            CalculateCost(product,productQuantity);
        }

        static void CalculateCost(string product, int productQuantity)
        {

            if (product == "water")
            {
                Console.WriteLine($"{productQuantity * 1.0:F2}");
            }
            else if (product == "coffee")
            {
                Console.WriteLine($"{productQuantity * 1.5:F2}");
            }
            else if (product == "coke")
            {
                Console.WriteLine($"{productQuantity * 1.4:F2}");
            }
            else if (product == "snacks")
            {
                Console.WriteLine($"{productQuantity * 2.0:F2}");
            }


        }

    }
}