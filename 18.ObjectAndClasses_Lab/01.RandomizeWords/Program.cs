namespace _01.RandomizeWords
{
    internal class Program
    {
        static void Main()
        {
            List<string> list = Console.ReadLine()
                .Split(" ")
                .ToList();

            Random rnd = new Random();

            for (int i = 0; i < list.Count; i++)
            {
                string valueAtIndex = list[i];
                int randomIndex = rnd.Next(0, list.Count);
                string randonValueAtIndex = list[randomIndex];

                list[i] = randonValueAtIndex;
                list[randomIndex] = valueAtIndex;
            }

            foreach (string valueAtIndex in list)
            {
                Console.WriteLine(valueAtIndex);
            }
        }
    }
}
