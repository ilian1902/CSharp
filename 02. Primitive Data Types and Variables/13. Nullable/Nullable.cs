//Create a program that assigns null values to an integer and to double variables. 
//Try to print them on the console, 
//try to add some values or the null literal to them and see the result.
using System;
class Nullable
{
    static void Main()
    {
        int? someint;
        double? somedouble;

        someint = 0;
        somedouble = 0d;
        Console.WriteLine("Null Integer = {0}\nNull Double = {1}", someint, somedouble);
        Console.WriteLine("Null Integer + 451 = {0}\nNull Double + 45.1 = {1}\n", someint + 451, somedouble + 45.1);

        someint = null;
        somedouble = null;
        Console.WriteLine("Nullable Integer =\'{0}\'\nNullable Double =\'{1}\'", someint, somedouble);
        Console.WriteLine("Nullable Integer + 451 =\'{0}\'\nNullable Double + 45.1 =\'{1}\'\n", someint + 451, somedouble + 45.1);

        someint = someint.GetValueOrDefault();
        somedouble = somedouble.GetValueOrDefault();
        Console.WriteLine("Default value of Integer is {0}\nDefault value of Decimal is {1}", someint, somedouble);
    }
}