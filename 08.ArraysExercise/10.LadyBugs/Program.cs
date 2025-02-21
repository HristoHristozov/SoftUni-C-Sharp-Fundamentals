namespace _10.LadyBugs
{
    public class Program
    {
        static void Main()
        {
            int fieldSize = int.Parse(Console.ReadLine());

            int[] field = new int[fieldSize];

            int[] ladyBugCurrentPlace = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            foreach (int index in ladyBugCurrentPlace)
            {
                if (index >= 0 && index < fieldSize)
                {
                    field[index] = 1;
                }
            }

            string command;

            while ((command = Console.ReadLine()) != "end")
            {
                string[] tokens = command.Split();

                int ladybugIndex = int.Parse(tokens[0]);
                string direction = tokens[1];
                int flyLenght = int.Parse(tokens[2]);

                if (ladybugIndex < 0 || ladybugIndex >= fieldSize || field[ladybugIndex] != 1)
                {
                    continue;
                }

                field[ladybugIndex] = 0;
                int nextIndex = ladybugIndex;

                while (true)
                {
                    if (direction == "right")
                    {
                        ladybugIndex += flyLenght;
                    }

                    else if (direction == "left")
                    {
                        ladybugIndex -= flyLenght;
                    }

                    if (ladybugIndex < 0 || ladybugIndex >= fieldSize)
                    {
                        break;
                    }

                    if (field[ladybugIndex] == 0)
                    {
                        field[ladybugIndex] = 1;
                        break;
                    }
                }
            }

            Console.WriteLine(string.Join(" ", field));
        }
    }
}
