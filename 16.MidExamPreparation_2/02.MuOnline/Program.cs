namespace _02.MuOnline
{
    internal class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split("|").ToArray();

            int roomCounter = 0;
            int healthPoints = 100;
            int bitcoins = 0;

            for (int i = 0; i < input.Length; i++)
            {
                string[] roomsTokens = input[i].Split(" ").ToArray();
                string encounter = roomsTokens[0];
                int amount = int.Parse(roomsTokens[1]);
                if (encounter == "potion")
                {
                    roomCounter++;


                    if (amount + healthPoints >= 100)
                    {
                        amount = 100 - healthPoints;
                        healthPoints = 100;
                    }
                    else
                    {
                        healthPoints += amount;
                    }
                    Console.WriteLine($"You healed for {amount} hp.");
                    Console.WriteLine($"Current health: {healthPoints} hp.");
                }

                else if (encounter == "chest")
                {
                    roomCounter++;
                    bitcoins += amount;
                    Console.WriteLine($"You found {amount} bitcoins.");
                }

                else
                {
                    roomCounter++;
                    healthPoints -= amount;
                    if (healthPoints <= 0)
                    {
                        Console.WriteLine($"You died! Killed by {encounter}.");
                        Console.WriteLine($"Best room: {roomCounter}");
                        return;
                    }
                    Console.WriteLine($"You slayed {encounter}.");
                }
            }

            Console.WriteLine("You've made it!");
            Console.WriteLine($"Bitcoins: {bitcoins}");
            Console.WriteLine($"Health: {healthPoints}");
        }
    }
}
