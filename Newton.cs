using System;
class Newton{
    public static void Main(){
        double sum = 1;
        for (int n = 1; n <= 20; n++) {
            for (int x = n; x >= 1; x--){
                factorial *= x;
            }
            sum += (1.0 / factorial);
        }
        Console.WriteLine("The value of \"e\" using Newton Series Expansion is: "+ sum);
    }
}