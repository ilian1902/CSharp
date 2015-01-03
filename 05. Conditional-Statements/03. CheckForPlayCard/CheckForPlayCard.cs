/*
 * Classical play cards use the following signs to designate the card face: 
 * 2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A. 
 * Write a program that enters a string 
 * and prints “yes” if it is a valid card sign or “no” otherwise.
 */

using System;

class CheckForPlayCard
{
    static void Main()
    {
        Console.WriteLine("Enter a sign to be checked");
        string sign = Console.ReadLine();

        bool isNumeral;
        bool isChar;
        byte numeralSign;
        char charSign;

        isNumeral = byte.TryParse(sign, out numeralSign);
        isChar = char.TryParse(sign, out charSign);

        if (isNumeral)
        {
            switch (numeralSign)
            {
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                case 10:
                    Console.WriteLine("Yes");
                    break;
                default: Console.WriteLine("No");
                    break;
            }
        }
        else if (isChar)
        {
            switch (charSign)
            {
                case 'J':
                case 'Q':
                case 'K':
                case 'A':
                    Console.WriteLine("Yes");
                    break;
                default: Console.WriteLine("No");
                    break;
            }
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}
