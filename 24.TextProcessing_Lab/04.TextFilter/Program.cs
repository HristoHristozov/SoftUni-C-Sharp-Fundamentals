namespace _04.TextFilter
{
    internal class Program
    {
        static void Main()
        {
            string[] bannedWords = Console.ReadLine().Split(", ");
            string input = Console.ReadLine();

            foreach (var word in bannedWords)
            {
                int lenght = word.Length;
                input = input.Replace(word, new string('*', word.Length));
            }

            Console.WriteLine(input);
        }
    }
}
