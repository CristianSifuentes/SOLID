namespace SingleResponsibilityPrincipleRefactor {
    class Program {
        static void Main(string[] args){
            CEmployee employee = new CEmployee("John Doe", "Software Engineer", 30, 60000);
            Console.WriteLine(employee);
            Console.WriteLine(CTaxesDepartment.CI(employee));
            CTaxesDepartment.PI(employee);


  
        }
    }
}