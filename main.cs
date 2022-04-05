// Created by: Jaejun Lee
// Created on: Mar 2022
//
// This program accepts user input

using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function calculates the area and perimeter of a right triangle
        int Base;
        int Height;
        int perimeter;

        Console.WriteLine("This program calculates the perimeter of a right triangle.");
        Console.WriteLine("");
        Console.Write("Enter the base (cm): ");
        Base = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the height (cm): ");
        Height = Convert.ToInt32(Console.ReadLine());

        perimeter = Height + Base + Math.Sqrt(Height * Height + Base * Base);

        Console.WriteLine("");
        Console.Write("Perimeter of the right triangle = " + perimeter + " cm");
        Console.ReadKey();
        Console.WriteLine("\nDone.");
    }
}