using System;
using System.Collections.Generic;
using System.Text;

namespace OpenCloredRefactor
{
    abstract class CBaseInventory
    {
        protected CProduct product;

        public CProduct Product { get => product; set => product = value; }


        public CBaseInventory(CProduct pProduct)
        {
            product = pProduct;
        }

        public override string ToString()
        {
            return product.ToString();
        }

        public abstract double CalculateProduct();
    }
}
