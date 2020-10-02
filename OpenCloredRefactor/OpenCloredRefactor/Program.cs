using System;
using System.Collections.Generic;

namespace OpenCloredRefactor
{
    class Program
    {
        static void Main(string[] args)
        {
            List<CBaseInventory> listProducts = new List<CBaseInventory>
            {
                new CAlimentInventory(new CProduct("Product 1", 1, 5)),
                new CAlimentInventory(new CProduct("Product 1", 1, 5)),
                new CAlimentInventory(new CProduct("Product 1", 1, 5)),
                new CMedicamentInventory(new CProduct("Product 1", 2, 5)),
                new CMedicamentInventory(new CProduct("Product 1", 2, 5)),
            };

            CStore myStore = new CStore(listProducts);
            myStore.CI();
        }
    }
}
