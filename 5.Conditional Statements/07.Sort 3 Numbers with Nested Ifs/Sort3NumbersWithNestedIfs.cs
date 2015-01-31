//Problem 7. Sort 3 Numbers with Nested Ifs
//
//    Write a program that enters 3 real numbers and prints them sorted in descending order.
//    Use nested if statements.

using System;

class Sort3NumbersWithNestedIfs
{
    static void Main()
    {
        Console.WriteLine("Please enter three number:");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        if (a > b)
        {
            if (a > c)
            {
                Console.Write(a + " ");
                if (b > c) Console.WriteLine(b + " " + c);
            }
            else
            {
                Console.WriteLine(c + " " + a + " " + b);
            }
        }
        else
        {
            if (b > c)
            {
                Console.Write(b + " ");
                if (a > c) Console.WriteLine(a + " " + c);
            }
            else
            {
                Console.WriteLine(c + " " + b + " " + a);
            }
        }
    }
}