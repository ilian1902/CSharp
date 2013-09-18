//A company has name, address, phone number, fax number, web site and manager. 
//The manager has first name, last name, age and a phone number. 
//Write a program that reads the information about a company and its manager 
//and prints them on the console.
using System;
class ComapnyInfo
{
    static void Main()
    {
        Console.WriteLine("Write down Company's Name");
        string cName = Console.ReadLine();
        Console.WriteLine("Write down Company's Address");
        string cAddress = Console.ReadLine();
        Console.WriteLine("Write down Company's Phone number");
        string cPhone = Console.ReadLine();
        Console.WriteLine("Write down Company's Fax number");
        string cFax = Console.ReadLine();
        Console.WriteLine("Write down Company's Web Site");
        string cWebSite = Console.ReadLine();

        Console.WriteLine("Write down Manager's First Name");
        string mFName = Console.ReadLine();
        Console.WriteLine("Write down Manager's Last Name");
        string mLName = Console.ReadLine();
        Console.WriteLine("Write down Manager's Age");
        string mAge = (Console.ReadLine());
        Console.WriteLine("Write down Manager's Phone number");
        string mPhone = Console.ReadLine();

        Console.WriteLine("{0}\nIs situated in {1}\nYou can contact us by\nPhone Number: {2}\nFax Number: {3}\nOr vist our Website: {4}\n"
            , cName, cAddress, cPhone, cFax, cWebSite);
        Console.WriteLine("CEO of {0}\n{1} {2}, {3} years old\nPhone Number:{4}", cName, mFName, mLName, mAge, mPhone);
    }
}