//Problem 12. Null Values Arithmetic
//
//    Create a program that assigns null values to an integer and to a double variable.
//    Try to print these variables at the console.
//    Try to add some number or the null literal to these variables and print the result.


using System;

class NullValuesArithmetic
{
    static void Main()
    {
        int? number1 = null;
        double? number2 = null;
        Console.WriteLine("{0}null{1}", number1, number2);

        number1 = 123456;

        Console.WriteLine(number1);

        number2 = 1234.56;

        Console.WriteLine(number2);
    }
}