namespace _03.CharactersInRange
{
    internal class Program
    {
        static void Main()
        {
            char startingChar = char.Parse(Console.ReadLine());
            char endingChar = char.Parse(Console.ReadLine());

            PrintCharactersInRange(startingChar, endingChar);
        }

        static void PrintCharactersInRange(char a, char b)
        {

            if (a < b)
            {
                for (int i = a + 1; i < b; i++)
                {
                    Console.Write($"{(char)i} ");
                }
            }
            else
            {
                for (int i = b + 1; i < a; i++)
                {
                    Console.Write($"{(char)i} ");
                }
            }
        }

    }
}
