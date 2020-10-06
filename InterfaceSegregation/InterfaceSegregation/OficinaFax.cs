using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSegregation
{
    class OficinaFax : IMultifuncional
    {
        public void Print()
        {
            throw new NotImplementedException();
        }

        public void Scanner()
        {
            throw new NotImplementedException();
        }

        public void Fax()
        {
            Console.WriteLine("Fax tu reporte");

        }


        public void Telephone()
        {
            Console.WriteLine("Telephone tu reporte");
        }
    }
}
