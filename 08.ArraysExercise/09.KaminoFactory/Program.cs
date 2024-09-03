namespace _09.KaminoFactory
{
    internal class Program
    {
        static void Main()
        {
            int dnaLength = int.Parse(Console.ReadLine());

            int bestLength = 0;
            int bestStartIndex = dnaLength;
            int bestSum = 0;
            int bestSequenceIndex = 0;
            int currentSequenceIndex = 0;
            int[] bestDNA = new int[dnaLength];

            string input;
            while ((input = Console.ReadLine()) != "Clone them!")
            {
                currentSequenceIndex++;

                int[] currentDNA = input
                    .Split(new char[] { '!' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                int currentLength = 0;
                int maxLength = 0;
                int startIndex = 0;
                int currentSum = currentDNA.Sum();

                for (int i = 0; i < currentDNA.Length; i++)
                {
                    if (currentDNA[i] == 1)
                    {
                        currentLength++;

                        if (currentLength > maxLength)
                        {
                            maxLength = currentLength;
                            startIndex = i - maxLength + 1;
                        }
                    }
                    else
                    {
                        currentLength = 0;
                    }
                }

                if (maxLength > bestLength ||
                    (maxLength == bestLength && startIndex < bestStartIndex) ||
                    (maxLength == bestLength && startIndex == bestStartIndex && currentSum > bestSum))
                {
                    bestLength = maxLength;
                    bestStartIndex = startIndex;
                    bestSum = currentSum;
                    bestSequenceIndex = currentSequenceIndex;
                    bestDNA = currentDNA;
                }
            }

            Console.WriteLine($"Best DNA sample {bestSequenceIndex} with sum: {bestSum}.");
            Console.WriteLine(string.Join(" ", bestDNA));
        }
    }
}