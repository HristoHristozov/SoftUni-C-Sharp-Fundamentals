namespace _03.TakeOrSkipRope
{
    internal class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            List<int> numbersList = input.Where(char.IsDigit).Select(ch => int.Parse(ch.ToString())).ToList();
            List<char> nonNumbersList = input.Where(ch => !char.IsDigit(ch)).ToList();

            List<int> takeList = numbersList.Where((num, index) => index % 2 == 0).ToList();
            List<int> skipList = numbersList.Where((num, index) => index % 2 != 0).ToList();

            string result = ExtractHiddenMessage(nonNumbersList, takeList, skipList);
            Console.WriteLine(result);
        }

        static string ExtractHiddenMessage(List<char> nonNumbers, List<int> takeList, List<int> skipList)
        {
            List<char> result = new List<char>();
            int currentIndex = 0;

            for (int i = 0; i < takeList.Count; i++)
            {
                int takeCount = takeList[i];
                int skipCount = skipList[i];

                result.AddRange(nonNumbers.Skip(currentIndex).Take(takeCount));
                currentIndex += takeCount;

                currentIndex += skipCount;
            }

            return new string(result.ToArray());
        }
    }
}
