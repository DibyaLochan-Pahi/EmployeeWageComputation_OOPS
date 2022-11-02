using System;

namespace UC8_EmpWageMultiCompany
{
    internal class MultiCompanyWage
    {
        // Print Welcome Message
        public MultiCompanyWage()
        {
            Console.WriteLine("WELCOME TO EMPLOYEE WAGE COMPUTATION PROBLEM");
            Console.WriteLine("---------------------------------------------");
        }
        
        static void Main(string[] args)
        {
            MultiCompanyWage multiCompanyWage = new MultiCompanyWage();

           //Method(Company Name, EmployeeWagePerHour,TotalWorkingDays,MaximumHouraMonth)
           
            EmpWage("RELIANCE", 20,20,100);
            Console.WriteLine("================================================================");
            EmpWage("DMART", 30, 25, 125);

        }
        // Calculate Employee Daily Wage, Status and Iterate Till Condition Reached
        public static void EmpWage(string company, int empWageperHour, int totalWorkingDays, int maxHour)
        {
            //Variable
            int empHour = 0;
            int empMonthWage = 0;
            int empTotalHour = 0;
            int empTotalDays = 0;
            Random random = new Random();
            while (empTotalHour < maxHour && empTotalDays < totalWorkingDays)
            {
                int count = random.Next(0, 3);
                switch (count)
                {
                    case 1:
                        Console.WriteLine("Employee is Present");
                        empHour = 8;
                        break;
                    case 2:
                        Console.WriteLine("Employee is Part Time");
                        empHour = 4;
                        break;
                    default:
                        Console.WriteLine("employee is Absent");
                        empHour = 0;
                        break;
                }
                int empWageDay = empHour * empWageperHour;
                Console.WriteLine("Today Employee Wage : " + empWageDay);
                empMonthWage = empWageDay + empMonthWage;
                empTotalHour = empHour + empTotalHour;
                empTotalDays++;
            }
            Console.WriteLine("\nEmployee Total Working Days is {0} and Working Hour is {1} in a Month at {2}", empTotalDays, empTotalHour, company);
            Console.WriteLine("Employee Monthly Wage is : " + empMonthWage);
        }

    }
}
