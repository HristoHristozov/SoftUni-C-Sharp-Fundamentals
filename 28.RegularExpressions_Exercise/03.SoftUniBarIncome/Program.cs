using System.Text.RegularExpressions;

namespace _03.SoftUniBarIncome
{
    internal class Program
    {
        static void Main()
        {
            string pattern = @"%(?<name>[A-Z][a-z]+)%[^|$%\.]*<(?<product>\w+)>[^|$%\.]*\|(?<count>\d+)\|[^|$%\.]*?(?<price>\d+(\.\d+)?)\$";

            string input;
            double totalIncome = 0.0;

            while ((input = Console.ReadLine()) != "end of shift")
            {
                Match match = Regex.Match(input, pattern);

                if (match.Success)
                {
                    string name = match.Groups["name"].Value;
                    string product = match.Groups["product"].Value;
                    int count = int.Parse(match.Groups["count"].Value);
                    double price = double.Parse(match.Groups["price"].Value);

                    double totalPrice = count * price;
                    totalIncome += totalPrice;

                    Console.WriteLine($"{name}: {product} - {totalPrice:F2}");
                }
            }

            Console.WriteLine($"Total income: {totalIncome:F2}");
        }
    }
}
