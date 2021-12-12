/*
The user is asked to type in any number of prices and when they are done, they type "no more"
and the total price is displayed.
When the user doesn't type "no more," the user gets to keep entering the prices.
After the user types "no more," the device calculates the price.
*/

using System;
class CashRegister{
    public static void Main(){
        string user = "";
        double price = 0, sum = 0, tax = 0;
        while(!(user == "No more")){
            Console.WriteLine("Enter price: ");
            price = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter\"No more\" if you are done. If not, keep typing the price.");
            user.Console.ReadLine();
            sum += price;
            Console.WriteLine("Your subtotal is :  " + sum);
        }
        tax = sum * 0.08675;
        Console.WriteLine("Your tax is : " + tax);
        Console.WriteLine("Your final total is : " + (tax + sum));
    }
}