namespace _04.CaesarCipher
{
    internal class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string result = string.Empty;
            foreach (char c in input)
            {
                int index = c + 3;
                char character = Convert.ToChar(index);
                result += character;
            }

            Console.WriteLine(result);
        }
    }
}
