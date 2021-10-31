/*
Creates user ID with the given first name, last name, and OSIS number
Takes the 1st letter of the first name, takes the last 4 letters of the last name, and the 
last 4 digits of the OSIS number
Combines the 3 information and displays the user ID
*/

using System;

class userID{
    public static void Main(){
        string fname, lname, osis, f1, l4, osis4;
        fname = ""; lname = ""; osis = ""; f1 = ""; l4 = ""; osis4 = "";

        Console.WriteLine("Enter first name: ");
        fname = Console.ReadLine();
        Console.WriteLine("Enter last name: ");
        lname = Console.ReadLine();
        Console.WriteLine("Enter osis #: ");
        osis = Console.ReadLine();

        f1 = fname.Substring(0, 1);
        l4 = lname.Substring(0, 4);
        osis4 = osis.Substring(5, 4);
        Console.WriteLine("Your user ID is: " + f1 + l4 + osis4);
    }
}