using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSegregationRefactor
{
    interface IMultiCompleto: IFax, IMultiBasico
    {
    }
}
