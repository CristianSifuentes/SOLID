namespace OpenClosedPrincipleRefactor {

    class CProduct {
        private string name;
        private int category;
        private double price;

        public string Name {
            get { return name; }
            set { name = value; }
        }
        public int Category {
            get { return category; }
            set { category = value; }
        }
        public double Price {
            get { return price; }
            set { price = value; }
        }

        // A Constructor is a special method that is called when an object is instantiated.
        // It is used to initialize the object's properties.
        // The constructor has the same name as the class and does not have a return type.
        
        public CProduct(string name, int category, double price) {
            this.name = name;
            this.category = category;
            this.price = price;
        }

        public override string ToString(){
            return $"Product Name: {name}, Category: {category}, Price: {price}";
        }


    }
    
}