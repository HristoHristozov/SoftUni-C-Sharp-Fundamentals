namespace _05.DecryptingMessage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte key = byte.Parse(Console.ReadLine());
            byte nCharacters = byte.Parse(Console.ReadLine());
            string message = "";

            for (int i = 1; i <= nCharacters; i++)
            {
                char letter = char.Parse(Console.ReadLine());

                int converted = (int)letter + key;

                Console.Write((char)converted);
            }
        }
    }
}