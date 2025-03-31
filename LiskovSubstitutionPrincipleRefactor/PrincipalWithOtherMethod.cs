
namespace LiskovSubstitutionPrincipleRefactor
{ 
    abstract class PrincipalWithOtherMethod: PrincipalBase {

        public PrincipalWithOtherMethod(string pMessage):base(pMessage){
        }

        public abstract void OtherMethod();
    }
}