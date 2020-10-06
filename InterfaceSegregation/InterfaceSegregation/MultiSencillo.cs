using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSegregation
{
    class MultiSencillo : IMultifuncional
    {

        public void Print()
        {
            Console.WriteLine("Imprimiendo tu reporte");
        }

        public void Scanner()
        {
            Console.WriteLine("Escaneando tu reporte");
        }

        public void Fax()
        {
            throw new NotImplementedException();
        }


        public void Telephone()
        {
            throw new NotImplementedException();
        }
    }
}
