/*
 * Write a program that prints an isosceles triangle of 9 copyright symbols ©, something like this:
 
   ©
  © ©
 ©   ©
© © © ©

 * Note that the © symbol may be displayed incorrectly at the console 
 * so you may need to change the console character encoding to UTF-8 and the console font.
 */

using System;
using System.Text;

class IsoscelesTriangle
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        char copyRight = '\u00a9';
        char space = '\u0020';

        Console.WriteLine("   {0}\n  {0} {0}\n {0}   {0}\n{0} {0} {0} {0}", copyRight);

        //or using 'for'loop
        Console.WriteLine("Enter the lenght of the hypotenuse [prefered to be odd number]");
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
