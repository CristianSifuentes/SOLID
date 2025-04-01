namespace LiskovSubstitutionPrincipleRefactor{
class New : PrincipalBase
     {
        public New(string pMessage): base(pMessage){

        }

        public override void Show(){
            Console.WriteLine("From new : {0}", message);
        }
    }
}