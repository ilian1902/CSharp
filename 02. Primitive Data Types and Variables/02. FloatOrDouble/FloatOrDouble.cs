/*
* Which of the following values can be assigned to 
* a variable of type float 
* and which to a variable of type double: 
* 34.567839023, 12.345, 8923.1234857, 3456.091
*/

using System;
class FloatOrDouble
{
    static void Main()
    {
        double first = 34.567839023D;
        float second = 12.345F;
        double third = 8923.1234857D;
        float fourth = 3456.091F;

        Console.WriteLine("{0}\n{1}\n{2}\n{3}"
                            , first, second, third, fourth);
    }
}