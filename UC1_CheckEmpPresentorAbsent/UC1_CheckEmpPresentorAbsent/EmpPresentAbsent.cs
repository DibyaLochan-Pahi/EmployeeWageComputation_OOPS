using System;

namespace UC1_CheckEmpPresentorAbsent
{
    internal class EmpPresentAbsent
    {
        public  EmpPresentAbsent()
        {
            Console.WriteLine("WELCOME TO EMPLOYEE WAGE COMPUTATION PROGRAM");
            Console.WriteLine("---------------------------------------------");
        }
        static void Main(string[] args)
        {
            EmpPresentAbsent empPresentAbsent = new EmpPresentAbsent();
            Random random = new Random();
            int empPresent = 0;
            EmpStatus(random,empPresent);
        }

        private static void EmpStatus(Random random, int empPresent)
        {
           int check=random.Next(0,2);
            if(check == empPresent)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }
    }
}
