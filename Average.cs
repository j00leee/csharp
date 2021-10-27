/*
Description: Create a program to calculate and display the average of 3 integers,
using variables. (Be sure to avoid the issue with integer division)
*/

using System;

class Average{
    public static void Main(){
        int num1, num2, num3;
        double avg;

        num1 = 5;
        num2 = -3;
        num3 = 0;
        avg = 0;

        avg = (num1 + num2 + num3) / 3.0;

        Console.WriteLine("The average of the three integers is: " + avg);
    }
}