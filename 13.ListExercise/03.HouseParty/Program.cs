namespace _03.HouseParty
{
    internal class Program
    {
        static void Main()
        {
            int numberOfCommands = int.Parse(Console.ReadLine());

            var isGoing = new List<string>();

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] input = Console.ReadLine().Split().ToArray();

                if (!isGoing.Contains(input[0]) && input.Length == 3)
                {
                    isGoing.Add(input[0]);
                }
                else if (isGoing.Contains(input[0]) && input.Length == 3)
                {
                    Console.WriteLine($"{input[0]} is already in the list!");
                }

                else if (input.Length > 3 && isGoing.Contains(input[0]))
                {
                    isGoing.Remove(input[0]);
                }

                else
                {
                    Console.WriteLine($"{input[0]} is not in the list!");
                }
            }

            foreach (var person in isGoing)
            {
                Console.WriteLine(person);
            }

        }
    }
}
