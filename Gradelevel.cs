/*
Checks to see what grade the user is in by looking at the official class code.
Asks the user for his/her class code and looks at the first number of the code to 
determine what grade he/she is.
If the official class code is 1, it displays "freshman", if 2, "sophomore",
if 3, "junior", if 4, "senior"
*/

using System;

class Gradelevel{
    public static void Main(){
        string ofc = "", grdl = "";
        
        Console.WriteLine("Enter your official class code: ");
        ofc = Console.ReadLine();

        grdl = ofc.Substring(0, 1);

        if(grdl == "1"){
            Console.WriteLine("You are a freshman");
        }
        else if(grdl == "2"){
            Console.WriteLine("You are a sophomore");
        }
        else if(grdl == "3"){
            Console.WriteLine("You are a junior");
        }
        else {
            Console.WriteLine("You are a senior")
        }
    }
}