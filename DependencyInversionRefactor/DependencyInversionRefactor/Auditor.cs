using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversionRefactor
{
    class Auditor
    {
        private IAuditable miStore;

        public Auditor(IAuditable pStore)
        {
            miStore = pStore;
        }

        public double totalAliments()
        {
            double total = 0;

            IEnumerable<Product> list = miStore.GetProducts(0);

            foreach (Product p in list)
            {

                    Console.WriteLine(p);
                    total += p.Price;
            }
            return total;

        }
    }
}
