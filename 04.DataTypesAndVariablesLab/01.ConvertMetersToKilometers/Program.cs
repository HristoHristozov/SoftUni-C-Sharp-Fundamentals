namespace _01.ConvertMetersToKilometers
{
    internal class Program
    {
        static void Main()
        {
            int distanceInMeters = int.Parse(Console.ReadLine());

            double convertToKM = distanceInMeters / 1000.0;

            Console.WriteLine($"{convertToKM:F2}");

        }
    }
}