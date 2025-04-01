
namespace DependencyInversionPrincipleRefactor {  

    class Store: IAuditable {

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

        public IEnumerable<Product> GetProducts(int pTipo)
        {
            List<Product> encontrados = new List<Product>();
            foreach(Product p in inventory)
            {
                if (p.Tipo == pTipo)
                    encontrados.Add(p);
            }
            return encontrados;
        }
    }
}
