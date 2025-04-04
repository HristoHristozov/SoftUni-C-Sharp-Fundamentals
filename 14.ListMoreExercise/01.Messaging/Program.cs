namespace _01.Messaging
{
    internal class Program
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string text = Console.ReadLine();

            List<char> charList = new List<char>(text);

            string result = "";

            foreach (int number in numbers)
            {
                int index = GetSumOfDigits(number) % charList.Count;
                result += charList[index];
                charList.RemoveAt(index);
            }

            Console.WriteLine(result);
        }

        static int GetSumOfDigits(int num)
        {
            int sum = 0;
            while (num > 0)
            {
                sum += num % 10;
                num /= 10;
            }
            return sum;
        }
    }
}
