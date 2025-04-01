namespace DependencyInversionPrincipleRefactor {  
        class Product{

            private string name;
            private int type;
            private double price;

            public string Nombre { get => name; set => name = value; }
            public int Tipo { get => type; set => type = value; }
            public double Price { get => price; set => price = value; }

            public Product(string pName, int pType, double pPrice){
                this.name = pName;
                this.type = pType;
                this.price = pPrice;
            }

        public override string ToString(){
           string strType = "";
           if(type == 0){
              strType = "Aliment";
           }else if (type == 1){
              strType = "Medicine";
           }else if (type == 2){
              strType = "clothes";
           }
           return strType;
        }
    }
}
