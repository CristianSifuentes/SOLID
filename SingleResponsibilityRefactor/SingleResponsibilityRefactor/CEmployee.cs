using System;
using System.Collections.Generic;
using System.Text;

namespace SingleResponsibilityRefactor
{
    class CEmployee
    {
        private string name;
        private string position;
        private int age;
        private double salary;

        public string Name { get => name; set => name = value; }
        public double Salary { get => salary; set => salary = value; }

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

        //here could exists new methods own of thsi class
        //Actual project
        //Assign schedule

    }
}
