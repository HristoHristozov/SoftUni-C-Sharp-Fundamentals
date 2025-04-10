namespace _03.MemoryGame
{
    internal class Program
    {
        static void Main()
        {
            List<string> elements = Console.ReadLine().Split().ToList();

            int turnsCounter = 0;

            string input = Console.ReadLine();
            while (true)
            {

                if (input == "end")
                {
                    break;
                }

                turnsCounter++;

                string[] indexes = input.Split();

                int firstIndex = int.Parse(indexes[0]);
                int secondIndex = int.Parse(indexes[1]);

                if (firstIndex >= 0 && secondIndex >= 0 && firstIndex < elements.Count && secondIndex < elements.Count && firstIndex != secondIndex)
                {

                    if (elements[firstIndex] == elements[secondIndex])
                    {
                        Console.WriteLine($"Congrats! You have found matching elements - {elements[firstIndex]}!");
                        if (firstIndex > secondIndex)
                        {
                            elements.RemoveAt(firstIndex);
                            elements.RemoveAt(secondIndex);
                        }
                        else
                        {
                            elements.RemoveAt(secondIndex);
                            elements.RemoveAt(firstIndex);
                        }


                        if (elements.Count == 0)
                        {

                            Console.WriteLine($"You have won in {turnsCounter} turns!");
                            return;
                        }
                    }

                    else if (elements[firstIndex] != elements[secondIndex])
                    {

                        Console.WriteLine("Try again!");
                    }

                }


                else
                {
                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                    elements.Insert(elements.Count / 2, $"-{turnsCounter}a");
                    elements.Insert(elements.Count / 2, $"-{turnsCounter}a");
                }

                input = Console.ReadLine();

            }

            Console.WriteLine("Sorry you lose :(");
            Console.WriteLine(String.Join(" ", elements));
        }
    }
}
