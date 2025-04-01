namespace SingleResponsibilityPrincipleRefactor {
    public class CTaxesDepartment {

        ///'otherMethods': cannot declare instance members in a static classCS0708
         public string otherMethods(){
            return "";
         }

        public static double CI(CEmployee employee) {
            return employee.Salary * 0.1; // 10% commission
        }
        
        public static void PI(CEmployee employee) {
            double imp = CI(employee);
            Console.WriteLine($"Pay {imp} in {employee.Name}");
        }
     
    }
}