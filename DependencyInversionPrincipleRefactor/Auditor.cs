namespace DependencyInversionPrincipleRefactor {
    class Auditor {
        
        private IAuditable store;
        public Auditor(IAuditable pStore){
            store = pStore;
        }

        public double totalAliments(){
            double total = 0;
            IEnumerable<Product> list = store.GetProducts(0);
            foreach(Product p in list)
            {
                Console.WriteLine(p);
                 total  += p.Price;
                
            }
            return total;
        }
    }
}