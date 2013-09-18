//Declare two string variables and assign them with “Hello” and “World”.
//Declare an object variable and assign it with the concatenation of the first two variables
//Declare a third string variable and initialize it with the value of the object variable
using System;
class DeclareObject
{
    static void Main()
    {
        string hello = "Hello";
        string world = "World";
        object obj = hello + " " + world;
        string message = (string)(obj);
        Console.WriteLine(message);
    }
}