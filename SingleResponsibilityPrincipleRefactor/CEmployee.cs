namespace SingleResponsibilityPrincipleRefactor {
    public class CEmployee {

        private string name;
        private string position;
        private int age;
        private double salary;
        public string Name {
            get { return name; }
            set { name = value; }
        }
        public double Salary {
            get { return salary; }
            set { salary = value; }
        }

        public CEmployee(string name, string position, int age, double salary) {
            this.name = name;
            this.position = position;
            this.age = age;
            this.salary = salary;
        }

        public override string ToString() {
            return $"Name: {name}, Position: {position}, Age: {age}, Salary: {salary}";
        }

    }
}