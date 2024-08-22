namespace _07.WaterOverflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfPours = int.Parse(Console.ReadLine());

            int tankCapacity = 255;

            for (int i = 0; i < numberOfPours; i++)
            {
                int litersOfWater = int.Parse(Console.ReadLine());
                if (tankCapacity - litersOfWater >= 0)
                {
                    tankCapacity -= litersOfWater;
                }
                else if(tankCapacity - litersOfWater < 0)
                {
                    Console.WriteLine("Insufficient capacity!");
                    continue;
                }
            }

            Console.WriteLine(255-tankCapacity);
        }
    }
}