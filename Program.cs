using System;

namespace Day8Problems
{

    internal class Program
    {
        static void Main(string[] args)
        {
            EmpCheack emp = new EmpCheack();
            emp.EmpWage();
        }
    }
    public class EmpCheack
    {

        public const int isPartTime = 1;
        public const int isFullTime = 2;
        public const int empRatePerHr = 20;
        public const int noOfWorkingDays = 2;
        public const int maxHrsInMonth = 10;

        public void EmpWage()
        {
            int empHr = 0, totalEmpHrs = 0, totalWorkingDays = 0;
            while (totalEmpHrs <= maxHrsInMonth && totalWorkingDays < noOfWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case isPartTime:
                        empHr = 4;
                        break;
                    case isFullTime:
                        empHr = 8;
                        break;
                    default:
                        empHr = 0;
                        break;

                }
                totalEmpHrs = totalEmpHrs + empHr;
                Console.WriteLine("Days=" + totalWorkingDays + "Emp Hrs=" + empHr);
            }
            int totalEmpWage = totalEmpHrs * empRatePerHr;
            Console.WriteLine("Total Emp Wage=" + totalEmpWage);
        }
    }

}
