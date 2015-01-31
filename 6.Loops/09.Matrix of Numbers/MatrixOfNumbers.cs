//Problem 9. Matrix of Numbers
//
//    Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) and prints a matrix like in the examples below. Use two nested loops.

using System;
using System.Text;

class MatrixOfNumbers
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("Enter an integer in the range (1 ≤ n ≤ 20):");
        int n = int.Parse(Console.ReadLine());
        int countCol = 1;
        if (n < 1 || n > 20)
        {
            Console.WriteLine("Invalid input!");
            return;
        }
        for (int i = 1; i <= n; i++)
        {
            for (int j = i; j < 2 * n; j++)
            {
                if (countCol <= n)
                {
                    Console.Write("{0} ", j);
                    countCol++;
                }
            }
            Console.WriteLine();
            countCol = 1;
        }
    }
}