using System.Runtime.CompilerServices;

namespace _10.PokeMon
{
    internal class Program
    {
        static void Main()
        {
            int pokePower = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());

            int targetsPoked = 0;
            int originalPower = pokePower;

            while (pokePower >= distance)
            {
                pokePower -= distance;
                targetsPoked++;

                double percent = originalPower * 0.5d;
                if (percent == pokePower && exhaustionFactor != 0)
                {
                    pokePower /= exhaustionFactor;
                }
            }

            Console.WriteLine(pokePower);
            Console.WriteLine(targetsPoked);
        }
    }
}