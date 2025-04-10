namespace _01.AdvertisementMessage
{
    internal class Program
    {
        static void Main()
        {
            int inputTimes = int.Parse(Console.ReadLine());

            string[] phrases = {"Excellent product.", "Such a great product.", "I always use that product.",
                "Best product of its category.", "Exceptional product.", "I can't live without this product." };

            string[] events = { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!"};

            string[] authors = { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };

            string[] cities = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            Random phrasesRND = new Random();
            Random eventsRND = new Random();
            Random authorsRND = new Random();
            Random citiesRND = new Random();

            for (int i = 0; i < inputTimes; i++)
            {
                int phraseIndex = phrasesRND.Next(0, phrases.Length);
                int eventsIndex = eventsRND.Next(0, events.Length);
                int authorsIndex = authorsRND.Next(0, authors.Length);
                int citiesIndex = citiesRND.Next(0, cities.Length);
                Console.WriteLine($"{phrases[phraseIndex]} {events[eventsIndex]} {authors[authorsIndex]} - {cities[citiesIndex]}");
            }
        }
    }
}
