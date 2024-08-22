using System.Numerics;

namespace _11.Snowballs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int snowballsMade = int.Parse(Console.ReadLine());

            BigInteger bestSnowballValue = 0;
            int bestSnowballQuality = 0;
            int bestsnowballSnow = 0;
            int bestsnowballTime = 0;

            for (int i = 0; i < snowballsMade; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());

                BigInteger snowballValue = BigInteger.Pow(snowballSnow / snowballTime,snowballQuality);

                if (snowballValue > bestSnowballValue)
                {
                    bestSnowballValue = snowballValue;
                    bestSnowballQuality = snowballQuality;
                    bestsnowballSnow = snowballSnow;
                    bestsnowballTime = snowballTime;
                }
            }

            Console.WriteLine($"{bestsnowballSnow} : {bestsnowballTime} = {bestSnowballValue} ({bestSnowballQuality})");


        }
    }
}