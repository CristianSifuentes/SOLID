using System;

namespace DependencyInversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store();
            double total = 0;

            store.AddProduct(new Product("Tomatoe", 0, 15.50));
            store.AddProduct(new Product("Banana", 0, 15.50));
            store.AddProduct(new Product("Pill", 1, 15.50));
            store.AddProduct(new Product("Apple", 2, 15.50));
            store.AddProduct(new Product("Medicine", 2, 15.50));
            store.AddProduct(new Product("t-shirt", 1, 15.50));

            Console.WriteLine("---------");


            Auditor auditor = new Auditor(store);
            total = auditor.totalAliments();

            Console.WriteLine("---------- {0}", total);



        }
    }
}
