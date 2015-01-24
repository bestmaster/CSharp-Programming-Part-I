//Problem 1. Odd or Even Integers
//
//    Write an expression that checks if given integer is odd or even.

using System;

class OddOrEvenIntegers
{
    static void Main()
    {
        Console.Write("Enter your number: ");
        int number = int.Parse(Console.ReadLine());

        bool isEven = number % 2 == 0;

        Console.WriteLine("This number is even = " + isEven);
    }
}