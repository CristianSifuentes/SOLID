namespace InterfaceSegregationPrinciple {
    class OfficeFax : IMultifunctional
    {
        public void Fax()
        {
            Console.WriteLine("Fax");
        }

        public void Print()
        {
            throw new NotImplementedException();
        }

        public void Scanner()
        {
            throw new NotImplementedException();
        }

        public void Telephone()
        {
            Console.WriteLine("Telephone");
        }
    }
}