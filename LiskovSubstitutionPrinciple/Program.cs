namespace LiskovSubstitutionPrinciple {
        class Program  {
            static void Main(string[] args) {
                News news = new News("New");
                news.Show();
                Radio radio = new Radio("Radio");
                radio.Show();
                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
                News substitutedNews = new Radio("Substituted Radio");
                substitutedNews.Show(); // This will call the overridden Show method in Radio class
                Console.WriteLine("Substituted news object created successfully.");
                Console.ReadLine();

            }
        }
}