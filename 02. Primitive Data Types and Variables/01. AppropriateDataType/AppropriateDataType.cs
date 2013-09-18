//Declare five variables choosing for each of them the most appropriate of the types 
//byte, sbyte, short, ushort, int, uint, long, ulong 
//to represent the following values: 
//52130, -115, 4825932, 97, -10000.
using System;
class AppropriateDataType
{
    static void Main()
    {
        ushort first = 52130;
        sbyte second = -115;
        int third = 4825932;
        byte fourth = 97;
        short fifth = -10000;
        Console.WriteLine("{0} {1} {2} {3} {4}", first, second, third, fourth, fifth);
    }
}