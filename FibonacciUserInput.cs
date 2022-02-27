using System;
class FibonacciUserInput{
    public static void Main() {
        int sum = 0, num1 = 0, num2 = 1, user = 0;
        Console.WriteLine("Enter the number of fibonacci numbers you want to see: ");
        user = int.Parse(Console.ReadLine());
        Console.WriteLine("\n1");
        for (int x = 0;  x < (user - 1); x++){
            sum = num1 + num2;
            Console.WriteLine(sum);
            num1 = num2;
            num2 = sum;
        }
    }
}