/*
This program displays the first 100 perfect square numbers.
To display the first 100 perfect square numbers, you use the for loop. We bump up x by 1 until x is 
less than or equal to 100.
When everything is displayed, the number goes all the way to 10000.
*/

using System;
class PerfectNumbers{
    public static void Main(){
        for(int x = 1; x <= 100; x++){
            Console.WriteLine(Math.Pow(x, 2));
        }
    }
}