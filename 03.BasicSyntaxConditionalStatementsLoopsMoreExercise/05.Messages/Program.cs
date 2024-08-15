namespace _05.Messages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int buttonPress = int.Parse(Console.ReadLine());
            string message = "";

            for (int i = 1; i <= buttonPress; i++)
            {
                string digits = Console.ReadLine();
                int digitLenght = digits.Length;
                int digit = digits[0] - '0';
                int offset = (digit - 2) * 3;

                if (digit == 0)
                {
                    message += (char)(digit + 32);
                    continue;
                }

                if (digit == 8 || digit == 9)
                {
                    offset++;
                }

                int letterIndex = offset + digitLenght - 1;
                message += (char)(letterIndex + 97);

            }

            Console.WriteLine(message);

        }
    }
}