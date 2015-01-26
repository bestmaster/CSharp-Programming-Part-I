//Problem 7. Sum of 5 Numbers
//
//    Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.

using System;

class SumOf5Numbers
{
    static void Main()
    {
        Console.WriteLine("Enter five numbers separated by a space:");
        string[] numbers = new string[5];
        double sum = 0;
        numbers = Console.ReadLine().Split();
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += Convert.ToDouble(numbers[i]);
        }
        Console.WriteLine(sum);
    }
}