namespace OpenClosedPrinciple{
   public class CProduct {
    private string name;
    private int  category;
    private double price;

    public string  Name {
        get { return name; }
        set { name = value; }
    }

    public int  Category {
        get { return category; }
        set { category = value; }
    }

    public double Price {
        get { return price; }
        set { price = value; }
    }

   
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