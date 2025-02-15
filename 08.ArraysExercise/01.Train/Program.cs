namespace _01.Train
{
    public class Program
    {
        static void Main()
        {
            int numberOfWagons = int.Parse(Console.ReadLine());

            int[] people = new int[numberOfWagons];
            int sumOfAllPassengers = 0;

            for (int i = 0; i < numberOfWagons; i++)
            {
                int passengersPerwagon = int.Parse(Console.ReadLine());
                people[i] = passengersPerwagon;
                sumOfAllPassengers += passengersPerwagon;
            }

            Console.WriteLine(string.Join(" ", people));
            Console.WriteLine(sumOfAllPassengers);
        }
    }
}