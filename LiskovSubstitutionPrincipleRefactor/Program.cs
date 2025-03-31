namespace LiskovSubstitutionPrincipleRefactor{
    class Program{
        static void Main(string[] args){

            PrincipalBase  newObj  = new New("New");
            newObj.Show();

            PrincipalWithOtherMethod  radioObj = new Radio("Radio");
            radioObj.Show();
            radioObj.OtherMethod();

        }
    }
}

