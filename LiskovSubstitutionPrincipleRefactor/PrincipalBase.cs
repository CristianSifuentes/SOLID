namespace LiskovSubstitutionPrincipleRefactor{ 

    abstract class PrincipalBase {
        protected string message;

        public PrincipalBase(string pMessage)
        {
            message = pMessage;
        }

        public abstract void Show();

    }
}