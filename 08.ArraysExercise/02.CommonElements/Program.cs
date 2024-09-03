using System;

namespace _02.CommonElements
{
    public class Program
    {
        static void Main()
        {
            string[] firstArr = Console.ReadLine().Split();

            string[] secondArr = Console.ReadLine().Split();

            string commonElements = "";

            foreach (string element in secondArr)
            {
                foreach (string value in firstArr)
                {
                    if (element == value)
                    {
                        commonElements += element + " ";
                    }
                }
            }

            Console.WriteLine(commonElements.TrimEnd());
        }
    }
}