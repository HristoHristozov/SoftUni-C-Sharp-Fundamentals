namespace _02.TheLift
{
    internal class Program
    {
        static void Main()
        {
            int peopleWaiting = int.Parse(Console.ReadLine());
            int[] currentState = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            decimal total = 0m;

            for (int i = 0; i < currentState.Length; i++)
            {
                for (int j = currentState[i]; j < 4; j++)
                {

                    peopleWaiting--;

                    if (peopleWaiting < 0)
                    {
                        break;
                    }
                    currentState[i]++;
                }
            }

            foreach (var item in currentState)
            {
                total += item;
            }

            if (currentState.Length * 4 > total)
            {
                Console.WriteLine("The lift has empty spots!");
            }

            else if (peopleWaiting > 0)
            {
                Console.WriteLine($"There isn't enough space! {peopleWaiting} people in a queue!");
            }

            foreach (var item in currentState)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
