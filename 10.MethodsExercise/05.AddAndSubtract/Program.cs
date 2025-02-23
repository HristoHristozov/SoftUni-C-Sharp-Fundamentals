namespace _05.AddAndSubtract
{
    internal class Program
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine(AddSubtract(a,b,c));
        }

        static int AddSubtract(int a, int b, int c)
        {
            return Add(a, b) - c;
        }

        static int Add(int a, int b)
        {
            return a + b;
        }
    }
}
