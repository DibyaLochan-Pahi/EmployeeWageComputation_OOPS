using System;

namespace UC3_AddPartTimeWage
{
    internal class AddPartTime
    {
        public const int empWagePerHour = 20;
        public AddPartTime()
        {
            Console.WriteLine("WELCOME TO EMPLOYEE WAGE COMPUTATION PROGRAM");
        }
        static void Main(string[] args)
        {
            AddPartTime addPartTime = new AddPartTime();
            int empHour = 0;
            Random random = new Random();
            EmpWageCalculator(empHour, random);
        }

        private static void EmpWageCalculator(int empHour, Random random)
        {
            int count = random.Next(0, 3);
            if (count == 0)
            {
                Console.WriteLine("Employee is Present");
                empHour = 8;
            }
            else if (count == 1)
            {
                Console.WriteLine("Employee is Part Time Emp");
                empHour = 4;
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
            Console.WriteLine("Employee Total Wage Today : " + empHour * empWagePerHour);
        }
    }
}

