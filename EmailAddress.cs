/*
Dissects email address to username, domain, and provider
Searches for a certain character to dissect the email address
Informs the user what its username, domain, and provider is
*/

using System;

class EmailAddress{
    public static void Main(){
        string email = "", username = "", provider = "", domain = "";
        int pos1 = 0, pos2 = 0, length = 0;

        Console.WriteLine("Enter your email address: ");
        email = Console.ReadLine();

        pos1 = email.IndexOf('@');
        username = email.Substring(0, pos1);
        pos2 = email.IndexOf('.');
        length = (pos2 - 1) - pos1;
        provider = email.Substring(pos1 + 1, length);
        domain = email.Substring(pos2 + 1);

        Console.WriteLine("Your username is: " + username);
        Console.WriteLine("Your provider is: " + provider);
        Cnosole.WriteLine("Your domain is: " + domain);
    }
}