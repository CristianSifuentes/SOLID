using System;
using System.Collections.Generic;
using System.Text;

namespace OpenCloredRefactor
{
    class CMedicamentInventory : CBaseInventory
    {
        public CMedicamentInventory(CProduct cProduct) : base(cProduct)
        {

        }
        public override double CalculateProduct()
        {
            product.Price *= 0.8;
            return product.Price;
        }
    }
}
