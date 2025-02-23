namespace _5.MultiplicationSign
{
    internal class Program
    {
        static void Main()
        {
            int negativeCounter = 0;
            bool isThereZero = false;

            for (int i = 0; i < 3; i++)
            {
                double currentNumber = double.Parse(Console.ReadLine());

                if (currentNumber < 0)
                {
                    negativeCounter++;
                }

                if (currentNumber == 0) isThereZero = true;
                
            }

            if (isThereZero)
            {
                Console.WriteLine("zero"); 
            }
            else if (negativeCounter % 2 == 1)
            {
                Console.WriteLine("negative");
            }
            else Console.WriteLine("positive");
        }
    }
}
