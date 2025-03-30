namespace OpenClosedPrinciple {
     class Program {
        public static void Main(string[] args) {
            List<CProduct> product = new List<CProduct>{
                new CProduct("Laptop", 1, 1200.00),
                new CProduct("Smartphone", 1, 800.00),
                new CProduct("Shoes", 2, 100.00),
                new CProduct("T-shirt", 3, 20.00)
            };

            CStore store = new CStore(product);
            store.CI();
            Console.ReadLine();

        }
    }

}