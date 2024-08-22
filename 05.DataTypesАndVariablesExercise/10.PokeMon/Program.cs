using System.Runtime.CompilerServices;

namespace _10.PokeMon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pokePower = int.Parse(Console.ReadLine());
            int pokeDistance = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());

            int originalN = pokePower;
            int targetPokedCount = 0;

            while (pokePower >= pokeDistance)
            {
                pokePower -= pokeDistance;
                targetPokedCount++;

                double percent = originalN * 0.5d;
                if (percent == pokePower && exhaustionFactor != 0)
                {
                    pokePower /= exhaustionFactor;
                }
            }

            Console.WriteLine(pokePower);
            Console.WriteLine(targetPokedCount);
        }
    }
}