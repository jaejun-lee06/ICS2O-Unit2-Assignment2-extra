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
        int bbase;
        int height;
        double perimeter;

        Console.WriteLine("This program calculates the perimeter of a right triangle.");
        Console.WriteLine("");
        Console.Write("Enter the base (cm): ");
        bbase = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the height (cm): ");
        height = Convert.ToInt32(Console.ReadLine());

        perimeter = height + bbase + Math.Sqrt(height * height + bbase * bbase);

        Console.WriteLine("");
        Console.Write("Perimeter of the right triangle = " + perimeter + " cm");
        Console.ReadKey();
        Console.WriteLine("\nDone.");
    }
}