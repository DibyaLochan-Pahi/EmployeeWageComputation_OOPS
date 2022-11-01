using System;

namespace UC2_CalculateDailyEmpWage
{
    internal class CalculateDailyWage
    {
        public const int empWagePerHour = 20;
        public CalculateDailyWage()
        {
            Console.WriteLine("WELCOME TO EMPLOYEE WAGE COMPUTATION PROGRAM");
        }
        static void Main(string[] args)
        {
            CalculateDailyWage calculateDailyWage = new CalculateDailyWage();
            int empHour=0;
            Random random=new Random();
            EmpWageCalculator(empHour,random);
        }

        private static void EmpWageCalculator(int empHour, Random random)
        {
            int count=random.Next(0,2);
            if (count == 0) 
            {
                Console.WriteLine("Employee is Present");
                empHour = 8;
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
            Console.WriteLine("Employee Total Wage Today : " + empHour*empWagePerHour);
        }
    }
}
