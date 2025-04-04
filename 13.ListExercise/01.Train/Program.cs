namespace _01.Train
{
    internal class Program
    {
        static void Main()
        {
            var passengersOnEachWagon = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int maxCapacityPerWagon = int.Parse(Console.ReadLine());

            string input;

            while ((input = Console.ReadLine()) != "end")
            {
                string[] tokens = input.Split().ToArray();
                string command = tokens[0];

                if (command == "Add")
                {
                    int wagon = int.Parse(tokens[1]);
                    passengersOnEachWagon.Add(wagon);
                }

                else
                {
                    int passenger = int.Parse(tokens[0]);
                    for (int i = 0; i < passengersOnEachWagon.Count; i++)
                    {
                        if (passengersOnEachWagon[i] + passenger <= maxCapacityPerWagon)
                        {
                            passengersOnEachWagon[i] += passenger;
                            break;
                        }
                    }
                }

            }
            Console.WriteLine(string.Join(" ", passengersOnEachWagon));
        }
    }
}
