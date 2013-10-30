//Write a program that finds the biggest of three integers using nested if statements

using System;
class BiggestOfThree
{
    static void Main()
    {
        Console.WriteLine("Enter the first integer");
        int first = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the second integer");
        int second = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the third integer");
        int third = int.Parse(Console.ReadLine());

        if (first > second && first > third)
        {
            Console.WriteLine("The biggest number is : {0}", first);
        }
        if (second > first && second > third)
        {
            Console.WriteLine("The biggest number is : {0}", second);
        }
        if (third > first && third > second)
        {
            Console.WriteLine("The biggest number is : {0}", third);
        }
        if ((first == second) && first > third)
        {
            Console.WriteLine("The biggest number is : {0} and it is equal to {1}", first, second);
        }

        if ((first == third) && first > second)
        {
            Console.WriteLine("The biggest number is :{0} and it is equal to {1}", first, third);
        }

        if ((second == third) && second > first)
        {
            Console.WriteLine("The biggest number is :{0} and it is equal to {1}", second, third);
        }
        if ((first == second) && (first == third) && (second == third))
        {
            Console.WriteLine("All three numbers are equal: {0} = {1} = {2}", first, second, third);
        }
    }
}