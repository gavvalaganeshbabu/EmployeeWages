using System;

namespace EmployeeWages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To EmployeeWage Computation :");
            Console.WriteLine("Calculating Wages Upto 100Hours and 20days :");
            Console.WriteLine("Enter Employee Name :");
            Random rnd = new Random();
            string name = Console.ReadLine();
            int n;
            int WagePerHour = 20;
            int FullDayHour = 8;
            int PartTimeHour = 4;
            int MonthTotalWorkingDays = 20;
            int WorkingDays = 20;
            int TotalWageOfMonth = 0;
            int TotalHours = 0;
            for (int i = 0; i <= MonthTotalWorkingDays&&WorkingDays<=20; i++)
            {
                n = rnd.Next(0, 3);
                switch (n)
                {
                    case 0:
                        TotalHours += FullDayHour;
                        TotalWageOfMonth += (FullDayHour * WagePerHour);
                        break;
                    case 1:
                        TotalHours+= PartTimeHour;  
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
            Console.WriteLine("Total Working Hours = "+TotalHours);
            Console.WriteLine("No of Working Days in Month = " + WorkingDays);
            Console.WriteLine("Total Wages in a Month = " + TotalWageOfMonth);
        }
    }      
    
}
