namespace _04.ListOperations
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

            while ((input = Console.ReadLine()) != "End")
            {
                string[] tokens = input.Split().ToArray();
                string command = tokens[0];

                if (command == "Add")
                {
                    int nubmer = int.Parse(tokens[1]);
                    list.Add(nubmer);
                }

                else if (command == "Insert")
                {
                    int nubmer = int.Parse(tokens[1]);
                    int index = int.Parse(tokens[2]);
                    if (index < list.Count && index >= 0)
                    {
                        list.Insert(index, nubmer);
                    }
                    else Console.WriteLine("Invalid index");
                }

                else if (command == "Remove")
                {
                    int index = int.Parse(tokens[1]);
                    if (index < list.Count && index >= 0)
                    {
                        list.RemoveAt(index);
                    }
                    else Console.WriteLine("Invalid index");
                }

                else if (command == "Shift")
                {
                    int count = int.Parse(tokens[2]);
                    if (tokens[1] == "left")
                    {
                        for (int i = 0; i < count; i++)
                        {
                            list.Add(list[0]);
                            list.RemoveAt(0);
                        }
                    }
                    else if (tokens[1] == "right")
                    {
                        for (int i = 0; i < count; i++)
                        {
                            list.Insert(0, list[list.Count - 1]);
                            list.RemoveAt(list.Count - 1);
                        }
                    }
                }

            }

            Console.WriteLine(string.Join(" ", list));
        }
    }
}
