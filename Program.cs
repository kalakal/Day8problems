using System;

namespace Day8Problems
{

    internal class Program
    {
        static void Main(string[] args)
        {
            EmpCheck emp = new EmpCheck();
            emp.EmpWage();
        }
    }
    public class EmpCheck
    {
        public const int isPartTime = 1;
        public const int isFullTime = 2;
        public const int empRatePerHr = 20;
        public const int noOfWorkingDays = 2;

        public void EmpWage()
        {
            int empHr = 0, empWage = 0, totalWage = 0;
            for (int day = 0; day <= noOfWorkingDays; day++)
            {
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
                empWage = empHr * empRatePerHr;
                totalWage = totalWage + empWage;
                Console.WriteLine("Emp Wage=" + empWage);
            }
            Console.WriteLine("total Wage =" + totalWage);
        }
    }

}
