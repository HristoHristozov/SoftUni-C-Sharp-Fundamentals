namespace _10.LadyBugs
{
    public class Program
    {
        static void Main()
        {
            int fieldSize = int.Parse(Console.ReadLine());

            int[] field = new int[fieldSize];

            int[] ladybugsIndexes = Console.ReadLine().Split().Select(int.Parse).ToArray();

            foreach (int index in ladybugsIndexes)
            {
                if (index >= 0 && index < fieldSize)
                {
                    field[index] = 1;
                }
            }

            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] commandParts = command.Split();
                int initialIndex = int.Parse(commandParts[0]);
                string direction = commandParts[1];
                int flyLength = int.Parse(commandParts[2]);

                if (initialIndex < 0 || initialIndex >= fieldSize || field[initialIndex] != 1)
                {
                    continue;
                }

                field[initialIndex] = 0; 
                int nextIndex = initialIndex;

                while (true)
                {
                    if (direction == "right")
                    {
                        nextIndex += flyLength;
                    }
                    else if (direction == "left")
                    {
                        nextIndex -= flyLength;
                    }

                    if (nextIndex < 0 || nextIndex >= fieldSize)
                    {
                        break;
                    }

                    if (field[nextIndex] == 0)
                    {
                        field[nextIndex] = 1;
                        break;
                    }
                }
            }

            Console.WriteLine(string.Join(" ", field));
        }
    }
}
