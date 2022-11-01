using System;

namespace UC4_SolvingbySwitchCase
{
    internal class EmpWageSwitchCase
    {
        public const int empWagePerHour = 20;
        public EmpWageSwitchCase()
        {
            Console.WriteLine("WELCOME TO EMPLOYEE WAGE COMPUTATION PROGRAM");
        }
        static void Main(string[] args)
        {
            EmpWageSwitchCase empWageSwitchCase = new EmpWageSwitchCase();
            int empHour = 0;
            Random random = new Random();
            EmpWageCalculator(empHour, random);
        }

        private static void EmpWageCalculator(int empHour, Random random)
        {
            int count = random.Next(0, 3);
            switch(count)
            {
                case 1:
                    Console.WriteLine("Employee is Present");
                    empHour = 8;
                    break;
                case 2:
                    Console.WriteLine("Employee is Half Time");
                    empHour = 4;
                    break;
                default:
                    Console.WriteLine("Employee is absent");
                    empHour = 0;
                    break;
            }

            Console.WriteLine("Employee Total Wage Today : " + empHour * empWagePerHour);
        }
    }
}
