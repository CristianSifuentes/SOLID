namespace LiskovSubstitutionPrincipleRefactor{

    class Radio : PrincipalWithOtherMethod{
        public Radio(string pMessage) : base(pMessage){

        }

        public override void Show()
        {
            Console.WriteLine("From radio: {0}", message);
        }

        public override void OtherMethod()
        {
            Console.WriteLine("From radio implement other method");
        }
    }
}