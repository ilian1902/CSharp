/*
 * You are given n integers (given in a single line, separated by a space). 
 * Write a program that checks whether 
 * the product of the odd elements is equal to the product of the even elements. 
 * Elements are counted from 1 to n, 
 * so the first element is odd, the second is even, etc. 
 * Examples:
numbers	        result
2 1 1 6 3	    yes
                product = 6
3 10 4 6 5 1	yes
                product = 60
4 3 2 5 2	    no
                odd_product = 16
                even_product = 15
 */

using System;

class OddAndEvenProduct
{
    static void Main()
    {
        Console.WriteLine("Enter Integers (given in a single line, separated by a space) :");
        string strNumbers = Console.ReadLine();

        string[] Numbers = strNumbers.Split(new char[] { '\u0020' }, StringSplitOptions.RemoveEmptyEntries);

        int oddProduct = 1;
        int evenProduct = 1;
        bool equalProducts = oddProduct == evenProduct;

        for (int i = 0; i < Numbers.Length; i++)
        {
            int number = int.Parse(Numbers[i]);

            if (i % 2 == 0)
            {
                evenProduct *= number;
            }
            else if (i % 2 != 0)
            {
                oddProduct *= number;
            }
        }

        Console.WriteLine(equalProducts ? "Yes\nProduct = {0}" : "No\nOddProduct = {0}\nEvenProduct = {1}"
                        , oddProduct, evenProduct);
    }
}
