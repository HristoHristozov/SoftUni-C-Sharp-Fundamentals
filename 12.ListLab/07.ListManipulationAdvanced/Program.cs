namespace _07.ListManipulationAdvanced
{
    internal class Program
    {
        static void Main()
        {

            var list = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string input;
            bool changesMade = false;

            while ((input = Console.ReadLine()) != "end")
            {
                string[] tokens = input.Split().ToArray();
                string command = tokens[0];

                if (command == "Contains")
                {
                    bool doesContain = list.Contains(int.Parse(tokens[1]));
                    if (doesContain)
                    {
                        Console.WriteLine("Yes");
                    }
                    else Console.WriteLine("No such number");
                }

                else if (command == "PrintOdd")
                {
                    Console.WriteLine(string.Join(" ", list.Where(n => n % 2 == 1)));
                }

                else if (command == "PrintEven")
                {
                    Console.WriteLine(string.Join(" ", list.Where(n => n % 2 == 0)));
                }

                else if (command == "GetSum")
                {
                    int sum = list.Sum(n => n);
                    Console.WriteLine(sum);
                }

                else if (command == "Filter")
                {
                    int number = int.Parse(tokens[2]);
                    if (tokens[1] == "<")
                    {
                        Console.WriteLine(string.Join(" ", list.Where(n => n < number)));
                    }
                    else if (tokens[1] == ">")
                    {
                        Console.WriteLine(string.Join(" ", list.Where(n => n > number)));
                    }

                    else if (tokens[1] == "<=")
                    {
                        Console.WriteLine(string.Join(" ", list.Where(n => n <= number)));
                    }
                    else if (tokens[1] == ">=")
                    {
                        Console.WriteLine(string.Join(" ", list.Where(n => n >= number)));
                    }
                }

                else if (command == "Add")
                {
                    changesMade = true;
                    list.Add(int.Parse(tokens[1]));
                }

                else if (command == "Remove")
                {
                    changesMade = true;
                    list.Remove(int.Parse(tokens[1]));
                }

                else if (command == "RemoveAt")
                {
                    changesMade = true;
                    list.RemoveAt(int.Parse(tokens[1]));
                }

                else if (command == "Insert")
                {
                    changesMade = true;
                    int number = int.Parse(tokens[1]);
                    int index = int.Parse(tokens[2]);
                    list.Insert(index, number);
                }
            }

            if (changesMade)
            {
                Console.WriteLine(string.Join(" ", list));
            }

        }
    }
}
