// Created by: Johanna Liu
// Created on: Mar 2022
//
// This program does basic math

using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function states user's address input.
        int hoursWorked;
        int hourlyRate;

        Console.WriteLine("This program will tell the user's employment information.");
        Console.WriteLine("");
        Console.Write("Enter the number of hours worked: ");
        hoursWorked = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the hourly rate: ");
        hourlyRate = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("");
        Console.WriteLine("Your pay is: $ " + ((hoursWorked * hourlyRate) * (1.00 - 0.18)).ToString("0.00") + ".");
        Console.WriteLine("The government will take: $ " + ((hoursWorked * hourlyRate) * 0.18).ToString("0.00") + ".");

        Console.WriteLine("\nDone.");
    }
}