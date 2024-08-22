namespace _08.BeerKegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int beerKegs = int.Parse(Console.ReadLine());

            string biggestKeg = "";
            decimal biggestVolume = 0;
            for (int i = 0; i < beerKegs; i++)
            {
                string kegModel = Console.ReadLine();
                decimal kegRadius = decimal.Parse(Console.ReadLine());
                int kegHeight = int.Parse(Console.ReadLine());


                decimal volume = (decimal)Math.PI * kegRadius * kegRadius * kegHeight;
                if (volume > biggestVolume)
                {
                    biggestVolume = volume;
                    biggestKeg = kegModel;
                }

            }

            Console.WriteLine(biggestKeg);
        }
    }
}