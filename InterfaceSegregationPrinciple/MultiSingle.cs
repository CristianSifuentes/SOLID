namespace InterfaceSegregationPrinciple {
    class MultiSingle : IMultifunctional
    {
        public void Fax()
        {
            throw new NotImplementedException();
        }

        public void Print()
        {
            Console.WriteLine("Print");
        }

        public void Scanner()
        {
            Console.WriteLine("Scanner");
        }

        public void Telephone()
        {
            throw new NotImplementedException();
        }
    }

}