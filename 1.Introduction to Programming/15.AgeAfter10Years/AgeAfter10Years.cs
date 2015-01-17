//Problem 15.* Age after 10 Years
//
//    Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.

using System;

    class AgeAfter10Years
    {
        static void Main()
        {
            string age = null;
            Console.WriteLine("How old are you?");
            Console.Write(">> ");
            age = Console.ReadLine();
            Console.WriteLine("After 10 years you'll be {0} years old.", int.Parse(age) + 10);
        }
    }