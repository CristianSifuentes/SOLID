using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversion
{
    class Store
    {
        private List<Product> inventory;

        public List<Product> Inventory { get => inventory; set => inventory = value; }

        public Store()
        {
            inventory = new List<Product>();
        }

        public void AddProduct(Product pProduct)
        {
            inventory.Add(pProduct);
            Console.WriteLine("Add {0}", pProduct.Nombre);
        }
    }
}
