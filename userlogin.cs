/*
Checks to see if the user entered the right username and password
Accepts the username and password from the user
If the user entered both the username and password correctly, the user has access, if not, a 
message pops up to inform the user that the computer is going to shut down
*/

using System;
using System.Diagnostics;

class userlogin{
    public static void Main(){
        string user = "", pw = "";

        Console.WriteLine("Please enter your username: ");
        user = Console.ReadLine();
        Console.WriteLine("Please enter your password: ");
        pw = Console.ReadLine();

        if (user == "person" && pw == "123"){
            Console.WriteLine("Access granted");
        }
        else{
            Console.WriteLine("Access not granted. System is going to shut down");
            Process.Start("shutdown.exe", "-s -f -t 300");
        }
    }
}