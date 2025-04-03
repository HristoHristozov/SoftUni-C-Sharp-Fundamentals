namespace _04.ListOfProducts
{
    internal class Program
    {
        static void Main()
        {
            int numberOfProducts = int.Parse(Console.ReadLine());

            var products = new List<string>();

            for (int i = 0; i < numberOfProducts; i++)
            {
                products.Add(Console.ReadLine());
            }

            products.Sort();
            int counter = 1;
            foreach (var product in products)
            {
                Console.WriteLine($"{counter}.{product}");
                counter++;
            }
        }
    }
}
