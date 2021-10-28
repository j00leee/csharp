using System;

class HelloWithInput{
    public static void Main(){
        string name;
        
        name = "";

        Console.WriteLine("Please enter your name: ");
        name = Console.ReadLine();

        Console.WriteLine("Hello " + name);
    }
}