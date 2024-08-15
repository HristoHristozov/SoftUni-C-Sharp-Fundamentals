namespace _04.ReverseString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] inputToCharArr = input.ToCharArray();
            Array.Reverse(inputToCharArr);

            Console.WriteLine(inputToCharArr);
        }
    }
}