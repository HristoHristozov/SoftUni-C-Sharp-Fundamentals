namespace _05.PrintPartOfASCIITable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startASCII = int.Parse(Console.ReadLine());
            int endASCII = int.Parse(Console.ReadLine());

            for (int i = startASCII; i <= endASCII; i++)
            {
                Console.Write($"{(char)i} ");
            }
        }
    }
}