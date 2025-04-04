namespace _04.MixedUpLists
{
    internal class Program
    {
        static void Main()
        {
            List<int> firstList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> secondList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();


            secondList.Reverse();

           int minLength = Math.Min(firstList.Count, secondList.Count);

            List<int> mixedList = new List<int>();
            for (int i = 0; i < minLength; i++)
            {
                mixedList.Add(firstList[i]);
                mixedList.Add(secondList[i]);
            }

            List<int> remainingElements = firstList.Count > secondList.Count
                    ? firstList.Skip(minLength).ToList()
                    : secondList.Skip(minLength).ToList();

            if (remainingElements.Count != 2)
            {
                Console.WriteLine("Invalid input: Expected exactly two remaining elements to define the range.");
                return;
            }

            int rangeStart = Math.Min(remainingElements[0], remainingElements[1]);
            int rangeEnd = Math.Max(remainingElements[0], remainingElements[1]);

            List<int> result = mixedList.Where(x => x > rangeStart && x < rangeEnd)
                            .OrderBy(x => x)
                            .ToList();

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
