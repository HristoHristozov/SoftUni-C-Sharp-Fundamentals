using System;

namespace BasicSyntaxConditionalStatementsLoopsLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var studentName = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());
            var averageGrade = double.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {studentName}, Age: {age}, Grade: {averageGrade:F2}");
        }
    }
}
