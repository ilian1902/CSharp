//Write an expression that checks for given integer if its third digit (right-to-left) is 7.
using System;
class ThirdDigitIs7Check
{
    static void Main()
    {
        Console.WriteLine("Enter an Integer number with at least 3 digits");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine((number / 100) % 10 == 7 ? "The third digit is 7" : "The third digit is Not 7");
    }
}