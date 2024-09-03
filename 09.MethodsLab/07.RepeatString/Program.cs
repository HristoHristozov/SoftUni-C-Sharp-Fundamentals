namespace _07.RepeatString
{
    public class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            int repeatInput = int.Parse(Console.ReadLine());

            string result = RepeatString(input,repeatInput);
            Console.WriteLine(result);
        }

        static string RepeatString(string str, int count)
        {
            string result = "";
            for (int i = 0; i < count; i++)
            {
                result += str;
            }

            return result;
        }
    }
}