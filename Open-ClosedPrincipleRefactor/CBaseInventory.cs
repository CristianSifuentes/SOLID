    namespace OpenClosedPrincipleRefactor {

        /// This is the base class for all inventory items. It contains a reference to a product and an abstract method to get the price.
        /// The class is abstract, meaning it cannot be instantiated directly. It is intended to be subclassed by other inventory classes.
        /// The class also overrides the ToString method to return a string representation of the product.
        /// The class is designed to be open for extension but closed for modification, following the Open/Closed Principle.
        /// This means that new inventory types can be added without modifying the existing code.
        abstract class CBaseInventory {
            protected CProduct product;

            public CProduct Product {
                get { return product; }
                set { product = value; }
            }

            public CBaseInventory(CProduct product) {
                this.product = product;
            }

            public override string ToString() {
                return product.ToString();
            }
            public abstract double GetPrice();

    } 
}
