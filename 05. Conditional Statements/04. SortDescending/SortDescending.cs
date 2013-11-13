//Sort 3 real values in descending order using nested if statements.

using System;
class SortDescending
{
    static void Main()
    {
        Console.WriteLine("Enter the first integer");
        int first = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the second integer");
        int second = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the third integer");
        int third = int.Parse(Console.ReadLine());

        if (first > second)
        {
            first = first + second;
            second = first - second;
            first = first - second;
        }
        if (first > third)
        {
            first = first + third;
            third = first - third;
            first = first - third;
        }
        if (second > third)
        {
            second = second + third;
            third = second - third;
            second = second - third;
        }
        Console.WriteLine("{0} {1} {2}"
                            , first, second, third);
    }
}