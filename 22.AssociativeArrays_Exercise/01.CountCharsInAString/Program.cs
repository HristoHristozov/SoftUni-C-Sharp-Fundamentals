namespace _01.CountCharsInAString
{
    internal class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            var counts = new Dictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                char currentChar = input[i];
                if (currentChar == ' ')
                {
                    continue;
                }
                if (!counts.ContainsKey(currentChar))
                {
                    counts.Add(currentChar, 1);
                }
                else counts[currentChar]++;
            }

            foreach (var character in counts)
            {
                Console.WriteLine($"{character.Key} -> {character.Value}");
            }
        }
    }
}
