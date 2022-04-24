using System;
class FactBro{
    public static void Main(){
        double sum = 0;
        for(int n = 0; n <= 6; n++){
            int factorial = 1;
            for(int x = (2*n + 1); x >= 1; x--){
                factorial *= x;
            }
            sum += 1.0 * (2 * n + 2) / factorial;
        }
        Console.WriteLine("The value of \"e\" using Newton series Expansion is: "+sum);
    }
}