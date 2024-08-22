using System.Diagnostics.CodeAnalysis;
using System.Numerics;

namespace _01.IntegerOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int firstInt = int.Parse(Console.ReadLine());
            int addToFirst = int.Parse(Console.ReadLine());
            int divideInt = int.Parse(Console.ReadLine());
            int multiplyInt = int.Parse(Console.ReadLine());

            BigInteger sum = ((firstInt + addToFirst) / divideInt) * multiplyInt;

            Console.WriteLine(sum);

        }
    }
}