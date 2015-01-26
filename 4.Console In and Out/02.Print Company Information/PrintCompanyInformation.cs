//Problem 2. Print Company Information
//
//    A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number.
//    Write a program that reads the information about a company and its manager and prints it back on the console.

using System;

class PrintCompanyInformation
{
    static void Main()
    {
        Console.Write("Company name: ");
        string compName = Console.ReadLine();
        Console.Write("Company address: ");
        string compAddress = Console.ReadLine();
        Console.Write("Phone number: ");
        int compPhoneNumb = int.Parse(Console.ReadLine());
        Console.Write("Fax number: ");
        int compFaxNumb = int.Parse(Console.ReadLine());
        Console.Write("Web site: ");
        string website = Console.ReadLine();
        Console.Write("Manager first name: ");
        string manFirstName = Console.ReadLine();
        Console.Write("Manager last name: ");
        string manLastName = Console.ReadLine();
        Console.Write("Manager age: ");
        int manAge = int.Parse(Console.ReadLine());
        Console.Write("Manager phone: ");
        int manPhoneNumb = int.Parse(Console.ReadLine());
        Console.WriteLine("-".PadRight(60, '-'));
        Console.WriteLine("{0}", compName);
        Console.WriteLine("Address: {0}", compAddress);
        Console.WriteLine("Tel. {0}", compPhoneNumb);
        Console.WriteLine("Fax: {0}", compFaxNumb);
        Console.WriteLine("Web site: {0}", website);
        Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3})", manFirstName, manLastName, manAge, manPhoneNumb);
        Console.WriteLine("-".PadRight(60, '-'));
    }
}