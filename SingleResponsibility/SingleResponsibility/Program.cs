using System;

namespace SingleResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            CEmployee cEmployee = new CEmployee("cristian", "enginner", 19, 1000);
            Console.WriteLine(cEmployee.CI());

        }
    }
}
