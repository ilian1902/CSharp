//Write a program that prints an isosceles triangle of 9 copyright symbols ©.
//Use Windows Character Map to find the Unicode code of the © symbol.
//Note: the © symbol may be displayed incorrectly
using System;
using System.Text;
class Triangle
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        char copyRight = '\u00a9';
        char space = '\u0020';

        Console.WriteLine("  {0}\n {0}{0}{0}\n{0}{0}{0}{0}{0}", copyRight);

        Console.WriteLine("Enter the lenght of the hypotenuse[prefered to be odd number]");
        int hypotenuse = int.Parse(Console.ReadLine());
        for (int i = hypotenuse / 2; i >= 0; i--)
        {
            int blankSpace = i;
            int symbol = hypotenuse - 2 * blankSpace;
            Console.Write(new string(space, blankSpace));
            Console.WriteLine(new string(copyRight, symbol));
        }
    }
}