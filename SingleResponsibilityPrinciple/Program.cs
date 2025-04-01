namespace SingleResponsibilityPrinciple
{
     class Program {
        static void Main(string[] args){
            CEmployee employee = new CEmployee("John Doe", "Software Engineer", 30, 60000);
            Console.WriteLine(employee.ToString());
            Console.WriteLine($"Commission: {employee.CI()}");
            employee.PI();
        }
    }

}