using System;
class n{
    public static void Main(){
        int n = 0, factor = 1;
        Console.WriteLine("Enter the value for n: ");
        n = int.Parse(Console.ReadLine());
        for(int x = n; x >= 1; x -= 1){
            factor *= x;
        }
        Console.WriteLine("The result is: " + n + " = " + factor);
    }
}