//Problem 8. Isosceles Triangle
//
//    Write a program that prints an isosceles triangle of 9 copyright symbols ©.

using System;
using System.Text;

class IsoscelesTriangle
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("   \u00A9   ");
        Console.WriteLine("  \u00A9 \u00A9  ");
        Console.WriteLine(" \u00A9   \u00A9 ");
        Console.WriteLine("\u00A9 \u00A9 \u00A9 \u00A9");
    }
}