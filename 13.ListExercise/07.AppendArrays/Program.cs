namespace _07.AppendArrays
{
    internal class Program
    {
        static void Main()
        {
            List<string> nums = Console.ReadLine()
                .Split("|")
                .Reverse()
                .ToList();

            List<int> result = new List<int>();

            foreach (var item in nums)
            {
                result.AddRange(item.Split(" ")
                        .Select(int.Parse)
                        .ToList());
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
