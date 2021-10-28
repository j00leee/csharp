using System;

class AreaPerimeterInput{
    public static void Main(){
        double L, W, A, P;
        L = 0;
        W = 0;
        A = 0;
        P = 0;

        Console.WriteLine("Please enter the length: ");
        L = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the width: ");
        W = double.Parse(Console.ReadLine());

        A = L * W;
        P 2 * (L + W);

        Console.WriteLine("Area is: " + A);
        Console.WriteLine("Perimeter is: " + P);
    }
}