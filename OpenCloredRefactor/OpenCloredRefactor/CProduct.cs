using System;
using System.Collections.Generic;
using System.Text;

namespace OpenCloredRefactor
{
    class CProduct
    {
        private string name;
        private int category;
        private double price;

        public string Name { get => name; set => name = value; }
        public int Category { get => category; set => category = value; }
        public double Price { get => price; set => price = value; }

        public CProduct(string pName, int pCategory, double pPrice)
        {
            name = pName;
            category = pCategory;
            price = pPrice;
        }

        public override string ToString()
        {
            return String.Format("The product {0} has a cost {1}", name, price);
        }
    }
}
