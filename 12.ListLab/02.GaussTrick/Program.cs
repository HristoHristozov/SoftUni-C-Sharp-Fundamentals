namespace _02.GaussTrick
{
    internal class Program
    {
        static void Main()
        {
            List<int> list = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> result = new List<int>();

            for (int i = 0; i < list.Count / 2; i++)
            {
                result.Add(list[i] + list[list.Count - i - 1]);
            }

            if (list.Count % 2 == 1)
            {
                result.Add(list[list.Count / 2]);
            }

            Console.WriteLine(string.Join(' ', result));
        }
    }
}
