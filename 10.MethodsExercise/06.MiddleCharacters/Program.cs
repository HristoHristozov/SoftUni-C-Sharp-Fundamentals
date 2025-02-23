namespace _06.MiddleCharacters
{
    internal class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            MiddleCharacters(input);
        }
        static void MiddleCharacters(string input)
        {
            string result = "";

            if (input.Length % 2 == 0)
            {
                result = input[input.Length / 2 - 1].ToString() + input[input.Length / 2];
            }
            else
            {
                result = input[input.Length / 2].ToString();
            }
            Console.WriteLine(result);
        }
    }
}
