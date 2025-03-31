namespace OpenClosedPrinciple{
    public class CStore {

        private List<CProduct> products = new List<CProduct>();

        public CStore(List<CProduct> pProducts) {
            this.products = pProducts;

        }

        public void CI(){
            double total = 0;
            foreach (CProduct cProduct in products){
                Console.WriteLine(cProduct);
                total += cProduct.Price;
            }

            Console.WriteLine($"Total Price: {total}");
            Console.WriteLine($"Total Products: {products.Count}");
            Console.WriteLine($"Average Price: {total / products.Count}");
            Console.WriteLine($"Most Expensive Product: {products.OrderByDescending(p => p.Price).First()}");
            Console.WriteLine($"Least Expensive Product: {products.OrderBy(p => p.Price).First()}");
            Console.WriteLine($"Most Common Category: {products.GroupBy(p => p.Category).OrderByDescending(g => g.Count()).First().Key}");
            Console.WriteLine($"Least Common Category: {products.GroupBy(p => p.Category).OrderBy(g => g.Count()).First().Key}");
            Console.WriteLine($"Total Price of Electronics: {products.Where(p => p.Category == 1).Sum(p => p.Price)}");
            Console.WriteLine($"Total Price of Footwear: {products.Where(p => p.Category == 2).Sum(p => p.Price)}");
            Console.WriteLine($"Total Price of All Products: {products.Sum(p => p.Price)}");

            //Change -> the total is calculated depending on the category of the product

            foreach(CProduct cProduct in products){
                if (cProduct.Category == 1){
                    total += cProduct.Price * 0.9; // 10% discount
                } else if (cProduct.Category == 2){
                    total += cProduct.Price * 0.8; // 20% discount
                } 
            }

            // this code is not open for extension, as we cannot add new categories without modifying the existing code
            // this violates the open-closed principle, as we have to modify the existing code to add new categories
            // to fix this, we can use the strategy pattern or the factory pattern to create a new class for each category  
            // and implement the discount logic in that class, so we can add new categories without modifying the existing code
            // this way, we can add new categories without modifying the existing code, and we can also change the discount logic for each category without modifying the existing code

        }
        
    }
}