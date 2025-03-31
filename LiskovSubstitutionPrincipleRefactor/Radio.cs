namespace LiskovSubstitutionPrincipleRefactor{

    class Radio : Principal{
        public Radio(string pMessage) : base(pMessage){

        }

        public override void OrherMethod()
        {
            Console.WriteLine("From radio implement other medhod");
        }

        public override void Show()
        {
            Console.WriteLine("From radio : {0}", message);
        }
    }
}