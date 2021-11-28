/*
The user has at least 5 tries to get the password and user id right
The user enters any combination of user id and password until the maximum he reached is 5
When the user tried over 5 times already and didn't get it right, the device informs the user 
that the user used up 5 tries otherwise, the device tells the user that the user got the
password right in 5 times or less.
*/

using System;
class LoginMax5{
    public static void Main(){
        string uid = "", pswd = "";
        int attempts = 1;
        while(!(uid == "abc" && pswd == "123")){
            Console.WriteLine("Enter user id: ");
            uid = Console.ReadLine();
            Console.WriteLine("Enter password: ");
            pswd = Console.ReadLine();
        }
        while(!(attempts > 5)){
            attempts = attempts + 1;
        }
        if(attempts > 5) Console.WriteLine("Maximum number of attempts used up.");
        else Console.WriteLine("User id and password are correct in " + (attempts - 1) + "tries.");
    }
}