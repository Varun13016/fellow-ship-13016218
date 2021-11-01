using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class EmpWageBuilderObject
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;

        private string company;
        private int empRatePerHour;
        private int numOfWorkingDays;
        private int maxHoursPerMonth;
        private int totalEmpWage;

        public EmpWageBuilderObject (string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHoursPerMonth = maxHoursPerMonth;
        }
        public void computeEmpWage()
        {
            int empHrs = 0, totalEmpHrs = 0, totalWorkingdays = 0;
            while (totalEmpHrs <= this.maxHoursPerMonth && totalWorkingdays< this.numOfWorkingDays)
            {
                totalWorkingdays++;
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
                Console.WriteLine("Day#:" + totalWorkingdays + "Emp Hrs:" + empHrs);
            }
            totalEmpWage = totalEmpHrs * this.empRatePerHour;
            Console.WriteLine("total Emp Wage for company:" + company + "is:" + totalEmpWage);
        }
        public string toString()
        {
            return "total Emp Wage for company:" + company + " is:" + totalEmpWage;
        }
    }
}
