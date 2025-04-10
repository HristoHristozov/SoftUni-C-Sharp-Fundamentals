namespace _03.Substring
{
    internal class Program
    {
        static void Main()
        {
            string stringToRemove = Console.ReadLine();
            string text = Console.ReadLine();

            while (text.Contains(stringToRemove))
            {
                int index = text.IndexOf(stringToRemove);
                int lenght = stringToRemove.Length;
                text = text.Remove(index, lenght);
            }

            Console.WriteLine(text);
        }
    }
}
