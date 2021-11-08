/*
Tells the user what type the solution is
Solves the root of the quadratic equation with the value the user gives
If d > 0, then it's two real solutions, if d = 0, it has one real solution, if 
d < 0, it has an imaginary solution
*/

using System;

class Discriminant{
    public static void Main(){
        double a = 0, b = 0, c = 0, d = 0;

        Console.WriteLine("Enter the value for a: ");
        a = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the value for b: ");
        b = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the value for c: ");
        c = double.Parse(Console.ReadLine());

        d = Math.Pow(b, 2) - (4 * a * c);

        if(d > 0){
            Console.WriteLine("Two real solutions");
        }
        if(d == 0){
            Console.WriteLine("One real solution");
        }
        if(d < 0){
            Console.WriteLine("Imaginary solution");
        }
    }
}
