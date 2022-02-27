using System;
class Fibonacci{
    public static void Main(){
        int sum = 0, num1 = 0, num2 = 1;
        Console.WriteLine("1");
        for (int x = 0; x < 19; x++){
            sum = num1 + num2;
            Console.WriteLine(sum);
            num1 = num2;
            num2 = sum;
        }
    }
}