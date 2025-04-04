namespace _05.BombNumbers
{
    internal class Program
    {
        static void Main()
        {
            var list = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            var bombNums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int bombNumber = bombNums[0];
            int bombPower = bombNums[1];

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == bombNumber)
                {
                    int start = i - bombPower;
                    if (start < 0)
                    {
                        start = 0;
                    }

                    int end = i + bombPower;
                    if (end > list.Count)
                    {
                        end = list.Count;
                    }

                    for (int j = start; j <= end; j++)
                    {
                        list[j] = 0;
                    }
                }
            }

            int sum = list.Sum();
            Console.WriteLine(sum);
        }
    }
}
