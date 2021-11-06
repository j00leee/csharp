/*
Checks to see if the user passed or not from the calculated average
Asks the user to enter 3 grades and the program calculates them
If the average is 65 or above, it displays that the user passed, but if
the average is 64 or lower, it displays for the user to try harder.
*/

using System;

class PassOrFail{
    public static void Main(){
        double grd1 = 0, grd2 = 0, grd3 = 0, avg = 0;

        Console.WriteLine("Enter first grade: ");
        grd1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter second grade: ");
        grd2 = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter last grade: ");
        grd3 = double.Parse(Console.ReadLine());

        avg = (grd1 + grd2 + grd3) / 3.0;

        if(avg >= 65){
            Console.WriteLine("You passed");
        }
        else{
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("You didn't pass. Try harder next time!");
        }
    }
}