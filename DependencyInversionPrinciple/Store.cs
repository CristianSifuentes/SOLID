namespace DependencyInversionPrinciple {  

    class Store {
        //This class violate Dependency Inversion Principle
        // Dependency injection
        private List<Product> inventory;
        public List<Product> Inventory {
            get => inventory;
            set => inventory  = value;
        } 
        public Store(){
            inventory = new List<Product>();
        }

        public void AddProduct(Product pProduct){
            inventory.Add(pProduct);
            Console.WriteLine("Add {0}", pProduct.Nombre);
        }
    }
}
