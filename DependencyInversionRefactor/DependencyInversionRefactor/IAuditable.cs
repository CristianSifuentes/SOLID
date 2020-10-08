using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversionRefactor
{
    interface IAuditable
    {
        IEnumerable<Product> GetProducts(int pTipo);
    }
}
