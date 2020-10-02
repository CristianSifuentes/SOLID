using System;

namespace Liskov
{
    class Program
    {
        static void Main(string[] args)
        {
            News news = new News("New");
            news.Show();

            Radio radio = new Radio("Radio");
            radio.Show();

            Console.WriteLine("-------");
            Console.ReadLine();

            News sustitution = new Radio("Estamos probando");
            sustitution.Show();

            Console.WriteLine("-------");
            Console.ReadLine();
        }
    }
}
