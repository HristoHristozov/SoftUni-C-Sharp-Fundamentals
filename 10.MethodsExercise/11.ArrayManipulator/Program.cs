namespace _11.ArrayManipulator
{
    internal class Program
    {
        static void Main()
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] tokens = command.Split();
                string action = tokens[0];

                switch (action)
                {
                    case "exchange":
                        int index = int.Parse(tokens[1]);
                        if (index >= 0 && index < array.Length)
                        {
                            array = Exchange(array, index);
                        }
                        else
                        {
                            Console.WriteLine("Invalid index");
                        }
                        break;

                    case "max":
                    case "min":
                        string type = tokens[1]; // even or odd
                        bool findMax = action == "max";
                        int resultIndex = FindMinMax(array, type, findMax);
                        Console.WriteLine(resultIndex == -1 ? "No matches" : resultIndex.ToString());
                        break;

                    case "first":
                    case "last":
                        int count = int.Parse(tokens[1]);
                        string parity = tokens[2]; // even or odd
                        bool firstElements = action == "first";

                        if (count > array.Length)
                        {
                            Console.WriteLine("Invalid count");
                        }
                        else
                        {
                            int[] result = GetFirstLastElements(array, count, parity, firstElements);
                            Console.WriteLine($"[{string.Join(", ", result)}]");
                        }
                        break;
                }
            }
            Console.WriteLine($"[{string.Join(", ", array)}]");
        }
        static int[] Exchange(int[] array, int index)
        {
            return array.Skip(index + 1).Concat(array.Take(index + 1)).ToArray();
        }

        static int FindMinMax(int[] array, string type, bool findMax)
        {
            var numbers = array
                .Select((num, i) => new { num, i }) // Store both number and index
                .Where(x => (type == "even" ? x.num % 2 == 0 : x.num % 2 != 0)) // Filter even/odd
                .ToList();

            if (!numbers.Any()) return -1; // No matches

            return findMax
                ? numbers.OrderByDescending(x => x.num).ThenByDescending(x => x.i).First().i
                : numbers.OrderBy(x => x.num).ThenByDescending(x => x.i).First().i;
        }

        static int[] GetFirstLastElements(int[] array, int count, string type, bool first)
        {
            var numbers = array.Where(num => (type == "even" ? num % 2 == 0 : num % 2 != 0)).ToArray();

            return first ? numbers.Take(count).ToArray() : numbers.Reverse().Take(count).Reverse().ToArray();
        }
    }
}
