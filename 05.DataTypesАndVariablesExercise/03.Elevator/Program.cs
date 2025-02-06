namespace _03.Elevator
{
    internal class Program
    {
        static void Main()
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            int elevatorCapacity = int.Parse(Console.ReadLine());

            double courses = Math.Ceiling((double)numberOfPeople / elevatorCapacity);

            Console.WriteLine(courses);

        }
    }
}