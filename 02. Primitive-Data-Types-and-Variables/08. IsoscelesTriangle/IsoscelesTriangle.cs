﻿/*
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
        // Also need to set the Console font to "Lucida Console"
        char copyRight = '\u00a9';

        Console.WriteLine("   {0}\n  {0} {0}\n {0}   {0}\n{0} {0} {0} {0}", copyRight);
    }
}
