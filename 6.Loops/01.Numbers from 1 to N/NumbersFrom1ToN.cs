//Problem 1. Numbers from 1 to N
//
//    Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n, on a single line, separated by a space.

using System;

class NumbersFrom1ToN
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        for (int index = 1; index <= number; index++)
        {
            Console.Write("{0} ", index);
        }
    }
}