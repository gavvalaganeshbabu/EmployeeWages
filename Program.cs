﻿using System;

namespace EmployeeWages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To EmployeeWage Computation :");
            Console.WriteLine("Calculating Full-Time And  Part-Time Wages :");
            Console.WriteLine("Enter Employee Name :");
            Random rnd = new Random();
            string name = Console.ReadLine();
            int n = rnd.Next(0, 3);
            int WagePerHour = 20;
            int FullDayHour = 8;
            int PartTimeHour = 4;
            if (n == 0)
            {
                Console.WriteLine("Employee is Absent Today : ");
                Console.WriteLine(name + " Wages = 0 $");
            }
            else if (n == 1)
            {
                Console.WriteLine(name + " is Present FullDay :");
                Console.WriteLine(name + " Wage = " + WagePerHour * FullDayHour + " $");
            }
            else
            {
                Console.WriteLine(name + " is Present Today and Worked partime :");
                Console.WriteLine("Employee Wage = " + WagePerHour * PartTimeHour + " $");
            }
        }      
    }
}
