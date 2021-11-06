/*
Checks to see whether the user gets a discount or not
Accepts the bill from the user and calculate to show the adjustable bill,
subtotal, discount, and tax
If the user spends over $100, the user get s a discount if not, the user
doesn't get a discount
*/

using System;

class BFinvoice{
    public static void Main(){
        double disc = 0, bill = 0, adjbill = 0, subtot = 0;

        Console.WriteLine("Enter bill: ");
        bill = double.Parse(Console.ReadLine());

        if(bill > 100){
            disc = bill * 0.1;
            subtot = bill - disc;
            adjbill = subtot * 1.08625;
            Console.WriteLine("Your discount bill is:\t$" + disc);
            Console.WriteLine("Your final invoice amount is:\t$" + adjbill);
        }

        else{
            Console.WriteLine("Your final invoice amount is:\t$" + (bill * 1.08625));
        }
    }
}