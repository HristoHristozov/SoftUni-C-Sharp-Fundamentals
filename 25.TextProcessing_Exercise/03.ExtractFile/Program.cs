namespace _03.ExtractFile
{
    internal class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            int startIndex = input.LastIndexOf('\\');
            int endIndex = input.IndexOf('.');

            string fileName = input.Substring(startIndex + 1, endIndex - startIndex - 1);
            string fileExntesion = input.Substring(endIndex + 1);

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {fileExntesion}");
        }
    }
}
