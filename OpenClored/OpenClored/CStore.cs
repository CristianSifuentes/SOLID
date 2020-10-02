using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClored
{
    class CStore
    {
        private List<CProduct> products;

        public CStore(List<CProduct> pProducts)
        {
            products = pProducts;
        }

        public void CI()
        {
            double total = 0;

            foreach(CProduct cProduct in products)
            {
                Console.WriteLine(cProduct);
                total += cProduct.Price;
            }

            //Cambio
            foreach (CProduct cProduct in products)
            {
                if(cProduct.Category == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    cProduct.Price *= 0.8;
                    Console.WriteLine(cProduct);
                    total += cProduct.Price;

                }
                if (cProduct.Category == 2)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    cProduct.Price *= 1.2;
                    Console.WriteLine(cProduct);
                    total += cProduct.Price;
                }
            }

            Console.WriteLine("Total is ", total);
        }
    }
}
