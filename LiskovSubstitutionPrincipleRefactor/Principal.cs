
namespace LiskovSubstitutionPrincipleRefactor
{ 
    abstract class Principal{
        protected string message;

        public Principal(string pMessage)
        {
            message = pMessage;
        }
        public abstract void Show();

        public abstract void OrherMethod();
    }
}