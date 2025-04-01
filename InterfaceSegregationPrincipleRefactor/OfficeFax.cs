namespace InterfaceSegregationPrincipleRefactor {
    class OfficeFax : IFax
    {
        public void Fax()
        {
            Console.WriteLine("Fax");
        }

        public void Telephone()
        {
            Console.WriteLine("Telephone");
        }
    }
}