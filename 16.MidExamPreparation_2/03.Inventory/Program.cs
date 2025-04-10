namespace _03.Inventory
{
    internal class Program
    {
        static void Main()
        {
            List<string> inventory = Console.ReadLine()
                .Split(", ")
                .ToList();

            string input = "";
            while ((input = Console.ReadLine()) != "Craft!")
            {
                string[] arguments = input.Split(" - ").ToArray();
                string command = arguments[0];
                string item = arguments[1];

                if (command == "Collect")
                {
                    if (!inventory.Contains(item))
                    {
                        inventory.Add(item);
                    }
                }

                else if (command == "Drop")
                {
                    if (inventory.Contains(item))
                    {
                        inventory.Remove(item);
                    }
                }

                else if (command == "Combine Items")
                {
                    string[] itemsForCombine = item.Split(":").ToArray();
                    string oldItem = itemsForCombine[0];
                    string newItem = itemsForCombine[1];
                    int oldItemIndex = inventory.IndexOf(oldItem);
                    if (inventory.Contains(oldItem))
                    {
                        inventory.Insert(oldItemIndex + 1, newItem);
                    }
                }

                else if (command == "Renew")
                {
                    if (inventory.Contains(item))
                    {
                        inventory.Remove(item);
                        inventory.Add(item);
                    }

                }



            }

            Console.WriteLine(String.Join(", ", inventory));
        }
    }
}
