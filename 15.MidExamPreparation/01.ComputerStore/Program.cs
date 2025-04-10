namespace _01.ComputerStore
{
    internal class Program
    {
        static void Main()
        {
            double totalPriceWithoutTax = 0.0;
            double tax = 0.0;
            double total = 0.0;

            while (true)
            {
                string command = Console.ReadLine();


                if (command == "special")
                {

                    tax = totalPriceWithoutTax * 20 / 100;
                    total = totalPriceWithoutTax + tax;
                    total -= total * 10 / 100;
                    if (total <= 0)
                    {
                        Console.WriteLine("Invalid order!");
                        break;
                    }
                    Console.WriteLine("Congratulations you've just bought a new computer!");
                    Console.WriteLine($"Price without taxes: {totalPriceWithoutTax:F2}$");
                    Console.WriteLine($"Taxes: {tax:F2}$");
                    Console.WriteLine("-----------");
                    Console.WriteLine($"Total price: {total:F2}$");
                    break;
                }

                else if (command == "regular")
                {

                    tax = totalPriceWithoutTax * 20 / 100;
                    total = totalPriceWithoutTax + tax;
                    if (total <= 0)
                    {
                        Console.WriteLine("Invalid order!");
                        break;
                    }
                    Console.WriteLine("Congratulations you've just bought a new computer!");
                    Console.WriteLine($"Price without taxes: {totalPriceWithoutTax:F2}$");
                    Console.WriteLine($"Taxes: {tax:F2}$");
                    Console.WriteLine("-----------");
                    Console.WriteLine($"Total price: {total:F2}$");
                    break;

                }

                double parts = double.Parse(command);

                if (parts < 0)
                {
                    Console.WriteLine("Invalid price!");
                    continue;
                }
                totalPriceWithoutTax += parts;
            }
        }
    }
}
