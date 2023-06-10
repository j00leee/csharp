using System;
class CompoundInterest {
    public static void Main() {
        int n = 0, t = 0;
        double p = 0, r = 0, A = 0;
        Console.WriteLine("Enter the principal amount:\t$");
        p = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the time period in years:\t");
        t = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the # of times interest is compounded per year:\t");
        n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the annual interest rate:\t");
        r = double.Parse(Console.ReadLine());

        A = p * Math.Pow(1 + (r/n), n * t);

        Console.WriteLine("\nYour final balance after "+t+" years is: $"+A);
        Console.WriteLine("\n\n---------- detailed Balance ----------");

        for(int x = 1; x <= n * t; x++){
            A = p * Math.Pow(1 + (r/n), 1);
            p = A;
            Console.WriteLine("Balancce after period "+x+" is: $"+A);
        }
    }
}