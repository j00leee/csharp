/*
Sees if the user entered the right password
Accepts the password from the user and checks to see if it's the right password
Informs the user if he/she can get access
*/

using System;

class Decisions{
    public static void Main(){
        string pwd = "";
        
        Console.WriteLine("Enter your password: ");
        pwd = Console.ReadLine();

        if(pwd.Equals("1234")){
            Console.WriteLine("Access granted");
        }
        else{
            Console.WriteLine("Please try again");
        }
    }
}