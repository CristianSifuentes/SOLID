using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSegregation
{
    class MultiAvanzado : IMultifuncional
    {
        public void Fax()
        {
            Console.WriteLine("Fax tu reporte");
        }

        public void Print()
        {
            Console.WriteLine("Imprimiendo tu reporte");
        }

        public void Scanner()
        {
            Console.WriteLine("Escaneando tu reporte");
        }

        public void Telephone()
        {
            Console.WriteLine("Telefono tu reporte");
        }
    }
}
