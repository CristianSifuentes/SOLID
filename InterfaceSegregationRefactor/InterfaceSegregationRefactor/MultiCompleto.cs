using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSegregationRefactor
{
    class MultiCompleto : IMultiCompleto
    {
        public void Faxear()
        {
            Console.WriteLine("Envio un fax");
        }

        public void Telefono()
        {
            Console.WriteLine("Te marco a un telefono");
        }

        public void Escanear()
        {
            Console.WriteLine("Escaneo una fotografia");
        }

        public void Imprimir()
        {
            Console.WriteLine("Imprimo un documento");
        }
    }
}
