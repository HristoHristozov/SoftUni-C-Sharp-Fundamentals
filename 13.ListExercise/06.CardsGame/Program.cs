namespace _06.CardsGame
{
    internal class Program
    {
        static void Main()
        {
            var firstCardsHand = Console.ReadLine()
               .Split()
               .Select(int.Parse)
               .ToList();

            var secondCardsHand = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            while (true)
            {
                if (firstCardsHand[0] > secondCardsHand[0])
                {
                    firstCardsHand.Add(firstCardsHand[0]);
                    firstCardsHand.Add(secondCardsHand[0]);
                }
                else if (secondCardsHand[0] > firstCardsHand[0])
                {
                    secondCardsHand.Add(secondCardsHand[0]);
                    secondCardsHand.Add(firstCardsHand[0]);
                }


                firstCardsHand.Remove(firstCardsHand[0]);
                secondCardsHand.Remove(secondCardsHand[0]);

                if (firstCardsHand.Count == 0)
                {
                    Console.WriteLine($"Second player wins! Sum: {secondCardsHand.Sum()}");
                    break;
                }
                else if (secondCardsHand.Count == 0)
                {
                    Console.WriteLine($"First player wins! Sum: {firstCardsHand.Sum()}");
                    break;
                }
            }
        }
    }
}
