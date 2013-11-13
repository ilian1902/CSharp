/*
 * Write a program that, depending on the user's choice inputs int, double or string variable. 
 * If the variable is integer or double, increases it with 1. 
 * If the variable is string, appends "*" at its end. 
 * The program must show the value of that variable as a console output. 
 * Use switch statement.
 */

using System;
class UserInput
{
    static void Main()
    {
        Console.WriteLine("Please enter:\n1 for Integer\n2 for Double\n3 for String");
        byte choice = byte.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                int integer = int.Parse(Console.ReadLine());
                Console.WriteLine(integer + 1);
                break;
            case 2:
                double floating = double.Parse(Console.ReadLine());
                Console.WriteLine(floating + 1);
                break;
            case 3:
                string str = Console.ReadLine();
                Console.WriteLine(str + "*");
                break;
            default: Console.WriteLine("Make selection:\n1 for Integer\n2 for Double\n3 for String");
                break;
        }
    }
}