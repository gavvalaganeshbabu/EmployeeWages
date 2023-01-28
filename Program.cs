using System;

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
                Console.WriteLine(name + " is Present Today");               
            }
            else {
                Console.WriteLine(name + " Is Absent Today");
            }
        }
    }
}
