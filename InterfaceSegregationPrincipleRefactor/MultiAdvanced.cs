namespace InterfaceSegregationPrincipleRefactor {
    class MultiAdvanced : IMultifunctional
    {
        public void Fax(){
            Console.WriteLine("Fax");
        }

        public void Print(){
            Console.WriteLine("Print");
        }

        public void Scanner(){
            Console.WriteLine("Scanner");
        }

        public void Telephone(){
            Console.WriteLine("Telephone");
        }
    }
}