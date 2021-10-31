using System;

namespace EmpWage_uc8
{
    class Program
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public static int computeEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            int empHrs = 0, totalEmpHrs = 0, totalworkingDays = 0;
            while (totalEmpHrs <= maxHoursPerMonth && totalworkingDays <= numOfWorkingDays)
            {
                totalworkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Day#:" + totalworkingDays + " EmpHrs : " + empHrs);
            }
            int tototalEmpWage = totalEmpHrs * empRatePerHour;
            Console.WriteLine("Total Emp Wage for company : " + company + " is: " + tototalEmpWage);
            return tototalEmpWage;
        }
        static void Main(string[] args)
        {
            computeEmpWage("Dmart", 20, 2, 10);
            computeEmpWage("REliance", 10, 4, 20);
        }
    }
}