using System;

namespace UC5_CalculateWageforMonth
{
    class CalWageMonth
    {
        // Print Welcome Message
        public CalWageMonth()
        {
            Console.WriteLine("WELCOME TO EMPLOYEE WAGE COMPUTATION PROGRAM");
        }
        //Declare Variable Globally
        public const int empWageperHour = 20;
        public const int totalWorkingDays = 20;
        static void Main(string[] args)
        {
            CalWageMonth calWageMonth = new CalWageMonth();
            int empHour = 0;
            int empMonthWage = 0;
            Random random = new Random();
            EmpWage(empHour, random, empMonthWage);
        }
        // Check Employee Status For A Month then Print Wages For Month
        private static void EmpWage(int empHour, Random random, int empMonthWage)
        {
            for (int i = 0; i <= totalWorkingDays; i++)
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
                Console.WriteLine("Today Employee Wage       : " + empWageDay);
                empMonthWage = empWageDay + empMonthWage;
            }
            Console.WriteLine("\nEmployee Wages for Month     : " + empMonthWage);
        }

    }
}
