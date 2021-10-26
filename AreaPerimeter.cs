/*
Create a program to create and display the area and perimeter of a rectangle, whose length and width
are known to the program. (use variables)
*/

/*
In this program, I learned how to calculate the area and perimeter of a rectangle by using the C# program. 
I also learned that when we declare variables, we can put the variables all in one line. Another thing I 
learned was that initializing the variables is when we give the values of the values of the variables.
Lastly, I learned that the "+" sign is used to append.
*/

using System;

class AreaPerimeter{
    public static void Main(){
        double L, W, A, P;
        L = 2.5;
        W = 4;
        A = 0;
        P = 0;

        A = L * W;
        P = 2 * (L + W);

        Console.WriteLine("Area is: " + A);

        Console.WriteLine("Perimeter is: " + P);
    }
}