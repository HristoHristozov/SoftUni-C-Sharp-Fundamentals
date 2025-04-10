namespace _04.SoftUniParking
{
    internal class Program
    {
        static void Main()
        {
            int commandsCount = int.Parse(Console.ReadLine());

            var registeredPeople = new Dictionary<string, string>();

            for (int i = 0; i < commandsCount; i++)
            {
                string[] tokens = Console.ReadLine().Split(' ');
                string command = tokens[0];
                string personName = tokens[1];


                if (command == "register")
                {
                    string licensePlate = tokens[2];
                    if (!registeredPeople.ContainsKey(personName))
                    {
                        registeredPeople.Add(personName, licensePlate);
                        Console.WriteLine($"{personName} registered {licensePlate} successfully");
                    }
                    else Console.WriteLine($"ERROR: already registered with plate number {licensePlate}");

                }

                else if (command == "unregister")
                {
                    if (!registeredPeople.ContainsKey(personName))
                    {
                        Console.WriteLine($"ERROR: user {personName} not found");
                    }

                    else
                    {
                        registeredPeople.Remove(personName);
                        Console.WriteLine($"{personName} unregistered successfully");
                    }
                }

            }

            foreach (var kvp in registeredPeople)
            {
                Console.WriteLine($"{kvp.Key} => {kvp.Value}");
            }
        }
    }
}
