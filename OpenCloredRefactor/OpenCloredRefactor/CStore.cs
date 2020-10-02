using System;
using System.Collections.Generic;
using System.Text;

namespace OpenCloredRefactor
{
    class CStore
    {
        private List<CBaseInventory> products;

        public CStore(List<CBaseInventory> pProducts)
        {
            products = pProducts;
        }

        public void CI()
        {
            double total = 0;

            foreach (var cProduct in products)
            {
                cProduct.CalculateProduct();
                Console.WriteLine(cProduct);
                total += cProduct.Product.Price;
            }

            Console.WriteLine("Total is ", total);
        }
    }
}
