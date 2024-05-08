using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");



        
    Fraction fractionOne = new Fraction();
    Fraction fractionTwo = new Fraction(5);
    Fraction fractionThree = new Fraction(3, 4);
    Fraction fractionFour = new Fraction(1, 3);
    // Fraction fractionFive = new Fraction();
    // Fraction fractionSix = new Fraction();
    // Fraction fractionSeven = new Fraction();
    // Fraction fractionEight = new Fraction();
    // Fraction fractionNine = new Fraction();

    Console.WriteLine(fractionOne.GetDecimalValue());
    Console.WriteLine(fractionTwo.GetDecimalValue());
    Console.WriteLine(fractionThree.GetDecimalValue());
    Console.WriteLine(fractionFour.GetDecimalValue());
    
    
    }

}