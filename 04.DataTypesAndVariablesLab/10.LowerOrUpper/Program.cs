namespace _10.LowerOrUpper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());

            if (Char.IsLower(firstChar))
            {
                Console.WriteLine("lower-case");
            }
            else Console.WriteLine("upper-case");
        }
    }
}