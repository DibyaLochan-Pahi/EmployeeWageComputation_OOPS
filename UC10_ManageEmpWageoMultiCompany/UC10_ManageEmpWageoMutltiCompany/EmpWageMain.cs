using System;

namespace UC10_ManageEmpWageoMutltiCompany
{
    internal class EmpWageMain
    {
        public EmpWageMain()
            {
                Console.WriteLine("Welome to Employee Wage Program");
                Console.WriteLine("========================================");
            }
            static void Main(string[] args)
            {
                EmpWageMain emp = new EmpWageMain(); 

                EmpWageBuilderArray empWageBuilder = new EmpWageBuilderArray();
                empWageBuilder.addCompanyEmpWage("DMart", 20, 2, 10);
                empWageBuilder.addCompanyEmpWage("Reliance", 10, 4, 20);
                empWageBuilder.addCompanyEmpWage("TCS", 15, 3, 15);
                empWageBuilder.addCompanyEmpWage("Samsung", 25, 5, 22);
                empWageBuilder.addCompanyEmpWage("Facebook", 30, 6, 25);
                empWageBuilder.computeEmpWage();
            }
        
    }
}
