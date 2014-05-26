﻿/*
 * A company has name, address, phone number, fax number, web site and manager. 
 * The manager has first name, last name, age and a phone number. 
 * Write a program that reads the information about a company 
 * and its manager and prints it back on the console.
program	            user
Company name:	    Software University
Company address:	26 V. Kanchev, Sofia
Phone number:	    +359 899 55 55 92
Fax number:	
Web site:	        http://softuni.bg
Manager first name:	Svetlin
Manager last name:	Nakov
Manager age:	    25
Manager phone:	    +359 2 981 981

Software University
Address: 26 V. Kanchev, Sofia
Tel. +359 899 55 55 92
Fax: (no fax)
Web site: http://softuni.bg
Manager: Svetlin Nakov (age: 25, tel. +359 2 981 981)
 */

using System;

class PrintCompanyInformation
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
        string manager = Console.ReadLine();
        string mFName = Console.ReadLine();
        Console.WriteLine("Write down Manager's Last Name");
        string mLName = Console.ReadLine();
        Console.WriteLine("Write down Manager's Age");
        string mAge = (Console.ReadLine());
        Console.WriteLine("Write down Manager's Phone number");
        string mPhone = Console.ReadLine();
        Console.Clear();

        Console.WriteLine("{0}\nAddress: {1}\nTel.: {2}\nFax: {3}\nWeb site: {4}\n"
                            , cName, cAddress, cPhone, cFax, cWebSite);
        Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3})"
                            , mFName, mLName, mAge, mPhone);

    }
}
