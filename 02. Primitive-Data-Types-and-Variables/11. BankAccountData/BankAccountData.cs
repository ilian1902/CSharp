/*
 * A bank account has a holder name 
 * (first name, middle name and last name), 
 * available amount of money (balance), bank name, IBAN, 
 * 3 credit card numbers associated with the account. 
 * Declare the variables needed to keep the information for 
 * a single bank account using the 
 * appropriate data types and descriptive names.
 */

using System;

class BankAccountData
{
    static void Main()
    {
        string firstName = "Ol\'";
        string middleName = "Dirty";
        string lastName = "Bastard";
        decimal balance = 123456789012345678901234567.89M;
        string bankName = "Digital Money Bank";
        string iban = "CHkk12345678901234567890";
        string bic = "DgtlMoneyBnk";
        ulong creditCard1 = 4885514993898;
        ulong creditCard2 = 4539282220808;
        ulong creditCard3 = 4485502136624;

        Console.WriteLine("{0} {1} {2}"
                            , firstName, middleName, lastName);
        Console.WriteLine("Total ammount of:\n{0} leva in {1}"
                            , balance, bankName);
        Console.WriteLine("Personal Account Information\nIBAN:{0}\nBIC:{1}"
                            , iban, bic);
        Console.WriteLine("Credit Card(s) Number:\n{0}\n{1}\n{2}"
                            , creditCard1, creditCard2, creditCard3);
    }
}
