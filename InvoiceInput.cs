using System;

class InvoiceInput{
    public static void Main(){
        double bill, taxrate, tax, famt;

        bill = 0;
        taxrate = 0.08625;
        tax = 0;
        famt = 0;

        Console.WriteLine("Enter bill amount: ");
        bill = double.Parse(Console.ReadLine());

        tax = bill * taxrate;
        famt = bill + tax;

        Console.WriteLine("Tax is: $" + tax);
        Console.WriteLine("Final amount is: $" + famt); 
    }
}