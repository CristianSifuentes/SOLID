using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversion
{
    class Auditor
    {
        private Store miStore;

        public Auditor(Store pStore)
        {
            miStore = pStore;
        }

        public double totalAliments()
        {
            double total = 0;

            foreach(Product p in miStore.Inventory)
            {
                if(p.Tipo == 0)
                {
                    Console.WriteLine(p);
                    total  += p.Price;

                }
            }
            return total;

        }
    }
}
