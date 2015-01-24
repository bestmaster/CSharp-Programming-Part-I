//Problem 3. Divide by 7 and 5
//
//    Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 at the same time.

using System;

class DivideBy7And5
{
    static void Main()
    {
        Console.Write("Enter your number: ");
        int number = int.Parse(Console.ReadLine());

        bool isDivided = (number % 5 == 0) && (number % 7 == 0);

        Console.WriteLine("This number can be divided by 7 and 5 = " + isDivided);
    }
}