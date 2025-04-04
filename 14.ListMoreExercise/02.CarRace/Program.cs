namespace _02.CarRace
{
    internal class Program
    {
        static void Main()
        {
            int[] times = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int middleIndex = times.Length / 2;
            double leftTime = 0, rightTime = 0;

            for (int i = 0; i < middleIndex; i++)
            {
                leftTime += times[i];
                if (times[i] == 0)
                {
                    leftTime *= 0.8;
                }
            }

            for (int i = times.Length - 1; i > middleIndex; i--)
            {
                rightTime += times[i];
                if (times[i] == 0)
                {
                    rightTime *= 0.8;
                }
            }

            string winner = leftTime < rightTime ? "left" : "right";
            double winningTime = Math.Min(leftTime, rightTime);

            if (winningTime == Math.Floor(winningTime))
            {
                Console.WriteLine($"The winner is {winner} with total time: {winningTime:F0}");
            }
            else Console.WriteLine($"The winner is {winner} with total time: {winningTime:F1}");
        }
    }
}
