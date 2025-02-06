namespace _02.PoundsToDollars
{
    internal class Program
    {
        static void Main()
        {
            double britishPound = double.Parse(Console.ReadLine());

            double dollar = britishPound * 1.31;

            Console.WriteLine($"{dollar:F3}");
        }
    }
}