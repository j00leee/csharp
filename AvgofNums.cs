/*
When the user enters the number of grades he wants to know, he gets to type in those grades
until the maximum number he wanted is reached.
If the user enters the number 5 for the number of grades, the user enters 5 grades and the 
accumulator increases by 1 each time the user enters in each grade to keep track of the amount
of grades the user entered.
After all the grades are entered, the device calculates and displays the average.
*/

using System;
class AvgofNums{
    public static void Main(){
        int max = 0, x = 0, grade = 0;
        double sum = 0;
        Console.WriteLine("Enter the number of grades you want to enter: ");
        max = int.Parse(Console.ReadLine());
        while(!(x == max)) {
            Console.WriteLine("Enter a grade: ");
            grade = int.Parse(Console.ReadLine());
            sum += grade;
            x += 1;
        }
        Console.WriteLine("The average of " + max + " grades is: " + sum/max);
    }
}