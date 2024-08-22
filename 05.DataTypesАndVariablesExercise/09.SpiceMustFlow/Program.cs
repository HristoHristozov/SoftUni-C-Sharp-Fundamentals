namespace _09.SpiceMustFlow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startingYield = int.Parse(Console.ReadLine());

            int totalSpiceExtracted = 0;
            int daysMined = 0;

            while (startingYield >= 100)
            {
                totalSpiceExtracted += startingYield;
                startingYield -= 10;
                totalSpiceExtracted -= 26;
                daysMined++;

            }

            if (totalSpiceExtracted < 26)
            {
                totalSpiceExtracted = 0;
            }
            else if (totalSpiceExtracted >= 26)
            { 
                totalSpiceExtracted -= 26;
            } 


            Console.WriteLine(daysMined);
            Console.WriteLine(totalSpiceExtracted);
        }
    }
}