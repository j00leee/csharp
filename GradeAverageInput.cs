using System;

class GradeAverageInput{
    public static void Main(){
        int num1, num2, num3;
        double avg;

        num1 = 0;
        num2 = 0;
        num3 = 0;
        avg = 0;

        Console.WriteLine("Enter grade: ");
        num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter second grade: ");
        num2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter third grade: ");
        num3 = int.Parse(Console.ReadLine());

        avg = (num1 + num2 + num3) / 3.0;

        Console.WriteLine("The average of the three grades is: " + avg);
    }
}