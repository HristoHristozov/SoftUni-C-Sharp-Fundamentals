namespace _03.MergingLists
{
    internal class Program
    {
        static void Main()
        {
            var firstList = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToList();

            var secondList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            var resultNums = new List<int>();

            for (int i = 0; i < Math.Min(firstList.Count, secondList.Count); i++)
            {
                resultNums.Add(firstList[i]);
                resultNums.Add(secondList[i]);
            }

            if (firstList.Count > secondList.Count)
            {
                resultNums.AddRange(GetRemainingElements(firstList, secondList));
            }
            else resultNums.AddRange(GetRemainingElements(secondList, firstList));

            Console.WriteLine(string.Join(" ", resultNums));
        }

        static List<int> GetRemainingElements(List<int> longerList, List<int> shorterList)
        {
            List<int> nums = new List<int>();
            for (int i = shorterList.Count; i < longerList.Count; i++)
            {
                nums.Add(longerList[i]);
            }
            return nums;
        }
    }
}
