/*
 * A marketing company wants to keep record of its employees. 
 * Each record would have the following characteristics:
•	First name
•	Last name
•	Age (0...100)
•	Gender (m or f)
•	Personal ID number (e.g. 8306112507)
•	Unique employee number (27560000…27569999)

 * Declare the variables needed to keep the information for a single employee 
 * using appropriate primitive data types. 
 * Use descriptive names. 
 * Print the data at the console.
 */

using System;

class EmployeeData
{
    static void Main()
    {
        string name = "Bobby";
        string family = "Digital";
        byte age = 255;
        char gender = 'М';
        ulong id = 9999999999;
        ushort uen = 9999;

        Console.WriteLine("Name:{0} {1}"
                            , name, family);
        Console.WriteLine("{0}, {1} years old"
                            , gender, age);
        Console.WriteLine("ID Number: {0}"
                            , id);
        Console.WriteLine("UEN: 2756{0, 0:D4}"
                            , uen);
    }
}