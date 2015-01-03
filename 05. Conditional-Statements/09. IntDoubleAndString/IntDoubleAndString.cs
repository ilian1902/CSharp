/*
 * Write a program that, depending on the user’s choice, 
 * inputs an int, double or string variable. 
 * If the variable is int or double, the program increases it by one. 
 * If the variable is a string, the program appends "*" at the end. 
 * Print the result at the console. 
 * Use switch statement.
 */

using System;

class IntDoubleAndString
{
    static void Main()
    {
        Console.WriteLine("Please choose a type:\n1 --> Integer\n2 --> Double\n3 --> String");
        byte choice = byte.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.WriteLine("Please enter a Integer:");
                int integer = int.Parse(Console.ReadLine());
                Console.WriteLine("Result: {0}", ++integer);
                break;
            case 2:
                Console.WriteLine("Please enter a Double:");
                double floating = double.Parse(Console.ReadLine());
                Console.WriteLine("Result: {0}", ++floating);
                break;
            case 3:
                Console.WriteLine("Please enter a String:");
                string str = Console.ReadLine();
                Console.WriteLine("Result: {0}*", str);
                break;
            default: Console.WriteLine("Input must be 1, 2 or 3");
                break;
        }
    }
}
