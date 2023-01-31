using System;

namespace EmployeeWages
{
    internal class Program
    {
        static int n;
        static int WagePerHour = 20;
        static int FullDayHour = 8;
        static int PartTimeHour = 4;
        static int MonthTotalWorkingDays = 20;
        static int WorkingDays = 20;
        static int TotalWageOfMonth = 0;
        static int TotalHours = 0;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To EmployeeWage Computation :");
            CalculateEmployeeWage();
        }
            public static void CalculateEmployeeWage() { 
            Console.WriteLine("Welcome To EmployeeWage Computation :");
            Console.WriteLine("Calculating Wages Upto 100Hours and 20days :");
            Console.WriteLine("Enter Employee Name :");
            Random rnd = new Random();
            string name = Console.ReadLine();
            
            for (int i = 0; i <= MonthTotalWorkingDays && WorkingDays <= 20; i++)
            {
                n = rnd.Next(0, 3);
                switch (n)
                {
                    case 0:
                        TotalHours += FullDayHour;
                        TotalWageOfMonth += (FullDayHour * WagePerHour);
                        break;
                    case 1:
                        TotalHours += PartTimeHour;
                        TotalWageOfMonth += (PartTimeHour * WagePerHour);
                        break;
                    case 2:
                        WorkingDays--;
                        TotalWageOfMonth += 0;
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine("Total Working Hours = " + TotalHours);
            Console.WriteLine("No of Working Days in Month = " + WorkingDays);
            Console.WriteLine("Total Wages in a Month = " + TotalWageOfMonth);
        }
    }
}
