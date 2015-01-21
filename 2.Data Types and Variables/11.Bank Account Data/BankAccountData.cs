//Problem 11. Bank Account Data
//
//    A bank account has a holder name (first name, middle name and last name), available amount of money (balance), bank name, IBAN, 
//    3 credit card numbers associated with the account.
//    Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.

using System;

class BankAccountData
{
    static void Main()
    {
        string holderFirstName = "Ceko";
        string holderMiddleName = "Kanalinov";
        string holderLastName = "Sifonia";
        decimal balance = 7.77M;
        string bankName = "KTB";
        string IBAN = "BG80BNBG12341234123412";
        string BIC_Code = "KORPBGSF";
        long creditCardNumber1 = 1122334455667788;
        long creditCardNumber2 = 2233445566778899;
        long creditCardNumber3 = 3344556677889900;

        Console.WriteLine("{0} {1} {2}\n{3}\n{4}\n{5}\n{6}\n{7}\n{8}\n{9}", holderFirstName, holderMiddleName, holderLastName, balance, bankName, IBAN, 
            BIC_Code, creditCardNumber1, creditCardNumber2, creditCardNumber3);
    }
}