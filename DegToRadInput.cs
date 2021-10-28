using System;

class DegToRadInput{
    public static void Main(){
        int deg;
        double rad;

        deg = 0;
        rad = 0;
        
        Console.WriteLine("Enter degrees: ");
        deg = int.Parse(Console.ReadLine());

        rad = deg * 3.14 / 180;

        Console.WriteLine(deg + "degrees = " + rad + "radians");
    }
}