/*
 * The gravitational field of the Moon is approximately 17% of that on the Earth. 
 * Write a program that calculates the weight of a man on the moon by a given weight on the Earth.
 */

using System;

class GravitationOnTheMoon
{
    static void Main()
    {
        Console.WriteLine("Enter weight on Earth");
        double weight = double.Parse(Console.ReadLine());

        double moonWeight = weight * 17 / 100;

        Console.WriteLine("The Earth weigth of {0}, on moon will be {1}"
                            , weight, moonWeight);
    }
}
