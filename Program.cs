using System;
using System.Security.Cryptography.X509Certificates;

namespace EmployeeWages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To EmployeeWage Computation :");
            Console.WriteLine("Enter the Employee Name :");
            string name=Console.ReadLine(); 
            Random rnd =new Random();
            int n=rnd.Next(0,2);
            if (n == 0)
            {
                Console.WriteLine(name + " Is Present Today");
                Console.WriteLine("Calculating Employee Wages Per Day : "+ CalculateWagePerDay());
                
            }
            else { 
            Console.WriteLine(name+" is Absent Today");
            }
            
            
        }
        public static int CalculateWagePerDay() {
            int WagePerday = 20;
            int WagePerHour = 8;
            return (WagePerday*WagePerHour);
        }
    }
}
