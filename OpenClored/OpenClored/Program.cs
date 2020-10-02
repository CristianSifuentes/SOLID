using System.Collections.Generic;
using System;

namespace OpenClored
{
    class Program
    {
        static void Main(string[] args)
        {
            List<CProduct> listProducts = new List<CProduct>
            {
                new CProduct("Product 1", 1, 5),
                new CProduct("Product 2", 1, 5),
                new CProduct("Product 3", 1, 5),
                new CProduct("Product 4", 2, 5),
                new CProduct("Product 5", 2, 5)
            };
            CStore myStore = new CStore(listProducts);
            myStore.CI();
            Console.ReadLine();


        }
    }
}
