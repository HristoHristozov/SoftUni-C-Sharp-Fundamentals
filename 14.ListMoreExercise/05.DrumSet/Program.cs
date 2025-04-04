namespace _05.DrumSet
{
    internal class Program
    {
        static void Main()
        {
            double savings = double.Parse(Console.ReadLine());

            List<int> initialDrumSet = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToList();

            List<int> currentDrumSet = new List<int>(initialDrumSet);

            string input;
            while ((input = Console.ReadLine()) != "Hit it again, Gabsy!")
            {
                int hitPower = int.Parse(input);

                for (int i = 0; i < currentDrumSet.Count; i++)
                {
                    currentDrumSet[i] -= hitPower;

                    if (currentDrumSet[i] <= 0)
                    {
                        int replacementCost = initialDrumSet[i] * 3;

                        if (savings >= replacementCost)
                        {
                            savings -= replacementCost;
                            currentDrumSet[i] = initialDrumSet[i];
                        }
                        else
                        {
                            currentDrumSet.RemoveAt(i);
                            initialDrumSet.RemoveAt(i);
                            i--; 
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(" ", currentDrumSet));

            Console.WriteLine($"Gabsy has {savings:F2}lv.");
        }
    }
}
