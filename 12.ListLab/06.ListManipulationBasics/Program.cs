namespace _06.ListManipulationBasics
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
            while ((input = Console.ReadLine()) != "end")
            {
                string[] tokens = input.Split().ToArray();
                string command = tokens[0];

                if (command == "Add")
                {
                    list.Add(int.Parse(tokens[1]));
                }

                else if (command == "Remove")
                {
                    list.Remove(int.Parse(tokens[1]));
                }

                else if (command == "RemoveAt")
                {
                    list.RemoveAt(int.Parse(tokens[1]));
                }

                else if (command == "Insert")
                {
                    int number = int.Parse(tokens[1]);
                    int index = int.Parse(tokens[2]);
                    list.Insert(index, number);
                }
            }

            Console.WriteLine(string.Join(" ", list));
        }
    }
}
