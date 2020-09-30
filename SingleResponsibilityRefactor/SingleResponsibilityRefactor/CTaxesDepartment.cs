using System;
using System.Collections.Generic;
using System.Text;

namespace SingleResponsibilityRefactor
{
    class CTaxesDepartment
    {
        //We have created a specialized class for other reponsability
        //Now this class has just one responsability
        public static double CI(CEmployee cEmployee)
        {
            return cEmployee.Salary * 0.35;
        }
        public static  void PI(CEmployee cEmployee)
        {
            double imp = CI(cEmployee);
            Console.WriteLine("Pay {0} in {1}", imp, cEmployee.Name);
        }
    }
}
