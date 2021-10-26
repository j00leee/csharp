/*
Create a program that prompts the user for an integer and a non-integer (number with a decimal part)
and then calculates and displays the sum of those 2 numbers. (use variables)
*/

//In this program, I learned when to use Parse and Console.ReadLine

using System;

class Add2Nums{
    public static void Main(){
        int num1;
        double num2, sum;
        num1 = 0;
        num2 = 0;
        sum = 0;

        Console.WriteLine("Please enter an integer: ");
        num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the second number: ");
        num2 = double.Parse(Console.ReadLine());

        sum = num1 + num2;

        Console.WriteLine("The sum of the numbers is: " + sum);
    }
}