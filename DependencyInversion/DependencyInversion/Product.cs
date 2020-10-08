using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversion
{
    class Product
    {
        private string name;
        private int type;
        private double price;


        public string Nombre { get => name; set => name = value; }
        public int Tipo { get => type; set => type = value; }
        public double Price { get => price; set => price = value; }


        public Product(string pName, int pType, double pCosto)
        {
            name = pName;
            type = pType;
            price = pCosto;
        }

        public override string ToString()
        {
            string strType = "";
            if (type == 0)
                strType = "Aliment";
            else if (type == 1)
                strType = "Medicine";
            else if (type == 2)
                strType = "Ropa";

            return string.Format("{0}, type {1}, price ${2}", name, strType, price);
        }
    }
}
