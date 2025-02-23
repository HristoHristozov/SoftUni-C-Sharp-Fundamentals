namespace _02.VowelsCount
{
    internal class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            CheckVowelsCount(input);
        }

        static void CheckVowelsCount(string input)
        {
            int vowelsSum = 0;
            input = input.ToLower();
            char[] chars = input.ToCharArray();

            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] == 'a' || chars[i] == 'e' || chars[i] == 'i' || chars[i] == 'o' || chars[i] == 'u')
                {
                    vowelsSum++;
                }
            }

            Console.WriteLine(vowelsSum);
        }
    }
}
