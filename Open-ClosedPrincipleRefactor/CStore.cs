namespace OpenClosedPrincipleRefactor {

     // internal is default access modifier for classes in C#.
     class CStore {
        private  List<CBaseInventory> products;

        public CStore(List<CBaseInventory> pProducts) {
            products = pProducts;
        }

        public void CI() {
            double total = 0;

            foreach (CBaseInventory product in products) {
                product.GetPrice();
                Console.WriteLine(product);
                total += product.Product.Price;
            }
             Console.WriteLine("Total is {0} ", total);

        }


    }
}