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
        int isPartTime = 1;
        int isFullTime = 2;
        int empRatePerHr = 20;
        int empHr = 0;
        int empWage = 0;

        public void EmpWage()
        {
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            if (empCheck == isPartTime)
            {
                empHr = 4;
            }
            else if (empCheck == isFullTime)
            {
                empHr = 8;
            }
            else
            {
                empHr = 0;
            }
            empWage = empHr * empRatePerHr;
            Console.WriteLine("EmpWage=" + empWage);
        }
    }

}
