namespace LiskovSubstitutionPrincipleRefactor{
class New : Principal
     {
        public New(string pMessage): base(pMessage){

        }

        public override void OrherMethod()
        {
            // This method is not implemented in the New class.
            // You can throw an exception or provide a default implementation if needed.
            // this method violates the Liskov Substitution Principle
            // because it does not provide a meaningful implementation for the New class.
            // You can choose to throw an exception or provide a default implementation.
            // For example, you can throw an exception like this:   
            //  throw new NotImplementedException("This method is not implemented in the New class.");
            // or provide a default implementation if needed.
            throw new NotImplementedException();
        }

        public override void Show(){
            Console.WriteLine("From new : {0}", message);
        }
    }
}