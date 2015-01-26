﻿//Problem 5. Formatting Numbers
//
//    Write a program that reads 3 numbers:
//        integer a (0 <= a <= 500)
//        floating-point b
//        floating-point c
//    The program then prints them in 4 virtual columns on the console. Each column should have a width of 10 characters.
//        The number a should be printed in hexadecimal, left aligned
//        Then the number a should be printed in binary form, padded with zeroes
//        The number b should be printed with 2 digits after the decimal point, right aligned
//        The number c should be printed with 3 digits after the decimal point, left aligned.

using System;

class FormattingNumbers
{
    static void Main()
    {
        Console.Write("a=");
        int a = int.Parse(Console.ReadLine());
        if (a >= 0 && a <= 500)
        {
            Console.Write("b=");
            float b = float.Parse(Console.ReadLine());
            Console.Write("c=");
            float c = float.Parse(Console.ReadLine());
            string inHex = a.ToString("x");
            string inBin = Convert.ToString(a, 2);
            Console.Write("|{0,-5}", inHex);
            Console.Write("|{0,5}|", inBin);
            Console.Write("{0,5}|", Math.Round(b, 2));
            Console.WriteLine("{0,-5}|", Math.Round(c, 3));
        }
        else
        {
            Console.WriteLine("a need to be in interval 0-500");
        }
    }
}