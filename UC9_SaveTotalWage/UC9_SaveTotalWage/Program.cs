using System;
using System.Collections.Generic;
using System.Text;

namespace UC9_SaveTotalWage
{
    class Program
    {
        static void Main(string[] args)
        {
            EmpWageBuilder dMart = new EmpWageBuilder("DMart", 20, 2, 10);
            EmpWageBuilder reliance = new EmpWageBuilder("Reliance", 10, 4, 20);
            dMart.computeEmpWage();
            Console.WriteLine(dMart.toString());
            reliance.computeEmpWage();
            Console.WriteLine(reliance.toString());
        }
    }
}
