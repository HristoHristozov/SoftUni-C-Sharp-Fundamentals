namespace _4.TribonacciSequence
{
    internal class Program
    {
        static void Main()
        {
            int sequenceLengt = int.Parse(Console.ReadLine());

            Tribonacci(sequenceLengt);
        }

        static void Tribonacci(int lenght)
        {
            if (lenght <= 1)
            {
                Console.WriteLine("1");
                return;
            }
            else if (lenght <= 2)
            {
                Console.WriteLine("1 1");
                return;
            }

            int first = 1;
            int second = 1;
            int third = 2;
            int next = 0;

            Console.Write(first + " " + second + " " + third + " ");

            for (int i = 3; i < lenght; i++)
            {
                next = first + second + third;
                Console.Write(next + " ");

                first = second;
                second = third;
                third = next;
            }
        }
    }
}
