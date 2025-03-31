
// This class is responsible for employee data and commission calculation.
// It also has a method to print the employee's information and commission.
// This violates the Single Responsibility Principle (SRP) because it has multiple responsibilities.
// The class should be split into two classes: one for employee data and another for commission calculation.
// The class should also be responsible for printing the employee's information.
// This can be done by creating a separate class for printing employee information and another for commission calculation.
namespace SingleResponsibilityPrinciple
{
  public class CEmployee {
    private string name;
    private string position;
    private int age;
    private double salary;

    public CEmployee(string name, string position, int age, double salary) {
        this.name = name;
        this.position = position;
        this.age = age;
        this.salary = salary;
    }

    public override string ToString() {
        return $"Name: {name}, Position: {position}, Age: {age}, Salary: {salary}";
    }

    public double CI(){
        return salary * 0.1; // 10% commission
    }
    public void PI(){
        double imp = CI();
        Console.WriteLine($"Pay {imp} in {name}");
    }
}
}



