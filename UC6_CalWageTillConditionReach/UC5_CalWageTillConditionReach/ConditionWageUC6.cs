using System;

namespace UC5_CalWageTillConditionReach
{
    class ConditionWageUC6
    {
        // Print Welcome Message
        public ConditionWageUC6()
        {
            Console.WriteLine("WELCOME TO EMPLOYEE WAGE COMPUTATION PROBLEM");
        }
        public const int empWageperHour = 20;
        public const int totalWorkingDays = 20;
        public const int maxHour = 100;
        static void Main(string[] args)
        {
            ConditionWageUC6 conditionWageUC6 = new ConditionWageUC6();
            int empHour = 0;
            int empMonthWage = 0;
            int empTotalHour = 0;
            int empTotalDays = 0;
            Random random = new Random();
            EmpWage(empHour, random, empMonthWage, empTotalHour, empTotalDays);
        }
        // Calculate Employee Daily Wage, Status and Iterate Till Condition Reached
        public static void EmpWage(int empHour, Random random, int empMonthWage, int empTotalHour, int empTotalDays)
        {
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
            Console.WriteLine("\nTotal Working Days is {0} and Tolal Working Hour is {1}",empTotalDays,empTotalHour);
            Console.WriteLine("Employee Monthly Wage is : " + empMonthWage);
        }

    }
}
