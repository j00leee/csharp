/*
Informs the user which state he/she lives in
Accepts the 5 digit zip code from the user and searches for the first two numbers to
dethermine where the user lives in
For example, if the user's zip code starts with 11, it displays, "you live in ny"
*/

using System;

class Zip{
    public static void Main(){
        string zip = "", zip1 = "";

        Console.WriteLine("Enter your zip code: ");
        zip = Console.ReadLine();
        zip1 = zip.Substring(0, 2);

        if(zip1 == "10" || zip1 == "11" || zip1 == "12" || zip1 == "13" || zip1 == "14"){
            Console.WriteLine("You live in NY");
        }
        if(zip1 == "07" || zip1 == "08"){
            Console.WriteLine("You live in NJ");
        }
        if(zip1 == "03" || zip1 == "04"){
            Console.WriteLine("You live in Maine");
        }
        if(zip1 == "84"){
            Console.WriteLine("You live in Utah");
        }
        if(zip1 == "40" || zip1 == "41" || zip1 == "42"){
            Console.WriteLine("You live in Kentucky");
        }
        if(zip1 == "43" || zip1 == "44" zip1 == "45"){
            Console.WriteLine("You live in Ohio");
        }
    }
}