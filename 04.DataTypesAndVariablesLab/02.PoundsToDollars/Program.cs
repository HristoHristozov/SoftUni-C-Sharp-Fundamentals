namespace _02.PoundsToDollars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double britishPound = double.Parse(Console.ReadLine());

            double convertToUSD = britishPound * 1.31;
            Console.WriteLine($"{convertToUSD:F3}");
        }
    }
}