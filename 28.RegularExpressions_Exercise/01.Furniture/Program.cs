using System.Text.RegularExpressions;

namespace _01.Furniture
{
    internal class Program
    {
        static void Main()
        {
            List<string> boughtFurniture = new List<string>();
            double totalSpent = 0.0;

            string pattern = @">>(?<name>[A-Za-z\s]+)<<(?<price>\d+(\.\d+)?)!(?<quantity>\d+)";
            string input;

            while ((input = Console.ReadLine()) != "Purchase")
            {
                Match match = Regex.Match(input, pattern);
                if (match.Success)
                {
                    string name = match.Groups["name"].Value;
                    double price = double.Parse(match.Groups["price"].Value);
                    int quantity = int.Parse(match.Groups["quantity"].Value);

                    boughtFurniture.Add(name);
                    totalSpent += price * quantity;
                }
            }

            Console.WriteLine("Bought furniture:");
            foreach (var furniture in boughtFurniture)
            {
                Console.WriteLine(furniture);
            }

            Console.WriteLine($"Total money spend: {totalSpent:F2}");
        }
    }
}
