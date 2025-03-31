namespace LiskovSubstitutionPrincipleRefactor{
    class Program{
        static void Main(string[] args){

            Principal principal = new New("New");
            principal.Show();
            principal.OrherMethod();

            Principal principal1 = new Radio("Radio");
            principal1.Show();

            Console.ReadLine();
            principal.OrherMethod();

        }
    }
}

