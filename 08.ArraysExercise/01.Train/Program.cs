namespace _01.Train
{
    public class Program
    {
        static void Main()
        {
            int lines = int.Parse(Console.ReadLine());

            int passengersSum = 0;
            int[] allPassengers = new int[lines];

            for (int i = 0; i < lines; i++)
            {
                int passengersPerWagon = int.Parse(Console.ReadLine());
                allPassengers[i] = passengersPerWagon;
                passengersSum += passengersPerWagon;
            }

            Console.WriteLine(string.Join(" ", allPassengers));
            Console.WriteLine(passengersSum);

        }
    }
}