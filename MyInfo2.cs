/*
Create a program to display output on multiple lines (using "\n", "\", and "\t"). Display the output
in a pop-up message box: System.Windows.Forms.MessageBox.Show(" ");
*/

/*
In this program, I learned many things such as "\" is used so that the computer won't get confused with
the single backslash with a lettle in front of it and that "\t" allows the output message line to be 
tabbed. Lastly. I learned that the "\..." is used so that the computer won't leave out the additional 
message in Console.WriteLine
*/

using System;

class MyInfo2{
    public static void Main(){
        Console.WriteLine("Name:\tJulie\nAge:23years");

    }
}