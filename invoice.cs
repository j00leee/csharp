/*
Create a program to calculate and display the tax and final amount for a bill amount provided
by the user. Use tax rate of 8.625%
tax = bill * tax rate
final amount = tax + bill
*/

using System;

class Invoice{
    public static void Main(){
        double bill, taxrate, tax, famt;
        
        bill = 10.00;
        taxrate = 0.08625;
        tax = 0.88;
        famt = 0;

        tax = bill * taxrate;
        famt = bill + tax;

        Console.WriteLine("Tax is: $" + tax);
        Console.WriteLine("Final amount is: $" + famt);
    }
}