namespace _01.SmallestOfThreeNumbers
{
    internal class Program
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine(FindSmallest(a, b, c));
        }

        static int FindSmallest(int a, int b, int c)
        {
            return Math.Min(Math.Min(a, b), c);
        }
    }
}
