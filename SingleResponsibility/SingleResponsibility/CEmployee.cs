using System;
using System.Collections.Generic;
using System.Text;

namespace SingleResponsibility
{
    class CEmployee
    {
        private string name;
        private string position;
        private int age;
        private double salary;

        public CEmployee(
            string pName, string pPosition, int pAge, double pSalary
            )
        {
            name = pName;
            position = pPosition;
            age = pAge;
            salary = pSalary;
        }

        public override string ToString()
        {
            return string.Format("{0}, {1}, {2}, {3}", name, position, age, salary);
        }

        public double CI()
        {
            return salary * 0.35;
        }
        public void PI()
        {
            double imp = CI();
            Console.WriteLine("Pay {} in {1}", imp, name);
        }

    }
}
