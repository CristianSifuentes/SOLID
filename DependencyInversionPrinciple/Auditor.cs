namespace DependencyInversionPrinciple {
    class Auditor {
        private Store myStore;

        public Auditor(Store pStore){
            myStore = pStore;
        }

        public double totalAliments(){
            double total = 0;
            foreach(Product p in myStore.Inventory)
            {
                if(p.Tipo == 0){
                    Console.WriteLine(p);
                    total  += p.Price;
                }
            }
            return total;
        }
    }
}