/*
the user enters in any password until he or she gets it right
The user enters a password and if it doesn't match the default password, the computer asks
the user the same question until the user gets it right
When the user enters the right password, the computer doesn't display the question anymore
and displays, "You got the password right."
*/

using System;
class Whileloop1{
    public static void Main(){
        string pswd = "";
        while(pswd != "1234"){
            Console.WriteLine("Enter a password: ");\
            pswd = Console.ReadLine();
        }
        Console.WriteLine("You got the password right.")
    }
}