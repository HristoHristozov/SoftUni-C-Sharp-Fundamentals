namespace _07.RepeatString
{
    public class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            int timesToRepeat = int.Parse(Console.ReadLine());

            Console.WriteLine(RepeatString(input,timesToRepeat));
        }

        static string RepeatString(string str, int repeat)
        {
            string result = "";

            for (int i = 0; i < repeat; i++)
            {
                result += str;
            }

            return result;
        }

        
    }
}