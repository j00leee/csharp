/*
Check/test an email address provided to see if its valid/invalid.
Check to see if "@" is present
Inform user of test results: valid/invalid
*/

using System;

class EmailValidation{
    public static void Main(){
        string email = "";
        int pos = 0;
        
        Console.WriteLine("Eter your email address: ");
        email = Console.ReadLine();

        pos = email.IndexOf('@');
        if(pos == -1){
            Console.WriteLine("Invalid email address");
        }
        else{
            Console.WriteLine("Valid email address");
        }
    }
}