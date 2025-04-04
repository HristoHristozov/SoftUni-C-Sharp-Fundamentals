using System.Collections.Generic;

namespace _02.ChangeList
{
    internal class Program
    {
        static void Main()
        {
            List<int> list = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string input;

            while ((input = Console.ReadLine()) != "end")
            {
                string[] tokens = input.Split().ToArray();
                string command = tokens[0];

                if (command == "Delete")
                {
                    int numberToRemove = int.Parse(tokens[1]);
                    list.RemoveAll(x => x == numberToRemove);
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
