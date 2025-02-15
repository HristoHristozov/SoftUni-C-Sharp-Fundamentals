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

            foreach (string element2 in secondArr)
            {
                foreach (string element in firstArr)
                {
                    if (element2.Equals(element))
                    {
                        commonElements += element2 + " ";
                    }
                }    
            }

            Console.WriteLine(commonElements);
        }
    }
}