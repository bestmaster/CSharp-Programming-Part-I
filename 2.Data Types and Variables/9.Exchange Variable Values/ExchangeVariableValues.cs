﻿//Problem 9. Exchange Variable Values
//
//    Declare two integer variables a and b and assign them with 5 and 10 and after that exchange their values by using some programming logic.
//    Print the variable values before and after the exchange.

using System;

class ExchangeVariableValues
{
    static void Main()
    {
        int number1 = 5;
        int number2 = 10;
        Console.WriteLine("Before exchange \u2192 number1={0} \b number2={1}", number1, number2);
        int number3;
        number3 = number1;
        number1 = number2;
        number2 = number3;
        Console.WriteLine("After exchange \u2192 number1={0} \b number2={1}", number1, number2);
    }
}