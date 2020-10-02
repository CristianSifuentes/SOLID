using System;
using System.Collections.Generic;
using System.Text;

namespace OpenCloredRefactor
{
    class CAlimentInventory : CBaseInventory
    {
        public CAlimentInventory(CProduct cProduct) : base(cProduct)
        {

        }

        public override double CalculateProduct()
        {
            product.Price *= 1.2;
            return product.Price;
        }
    }
}
