using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSegregationRefactor
{
    class Fax : IFax
    {
        public void Faxear()
        {
            Console.WriteLine("Envio un fax");
        }

        public void Telefono()
        {
            Console.WriteLine("Te marco a un telefono");
        }
    }
}
