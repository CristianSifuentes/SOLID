using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSegregationRefactor
{
    class MultiBasico : IMultiBasico
    {
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
