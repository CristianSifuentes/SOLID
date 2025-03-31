namespace OpenClosedPrincipleRefactor {
      class Program {
            static void Main(string[] args){

            List<CBaseInventory> listProducts = new List<CBaseInventory>
            {
                 new CAlimentInventory(new CProduct("Laptop", 1, 5)),
                 new CAlimentInventory(new CProduct("Smartphone 2", 1, 2)),
                 new CAlimentInventory(new CProduct("Product 3", 1, 9)),
                 new CMedicamentInventory(new CProduct("Shoes", 2, 5)),
                 new CMedicamentInventory(new CProduct("T-shirt", 2, 7)),

            };

            CStore myStore = new CStore(listProducts);
            myStore.CI();
           }
      }
    
}