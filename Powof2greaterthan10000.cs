/*
The goal is to find the number so that 2 to the power of a number is greater than 10,000.
We use the while loop and when the condition isn't met, we bump up x by 1.
Output: The value of x is 14.
*/

using System;
class Powof2greaterthan10000{
    public static void Main(){
        int x = 0;
        while(Math.Pow(2, x) <= 10000){
            x++;
            Console.WriteLine("Number is " + x);
        }
    }
}