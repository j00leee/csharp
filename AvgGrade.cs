/*
The teacher is allwoed to enter as many grades he wants and when he is done, the user enters -1 to 
state that he is done entering the grades.
The user enters as many grades and after he is done, he enters -1 and then the device caluclates the average
but adds 1 so that the entering of -1 won't be affected.
The average of all the grades are calculated and displayed to the user.
*/

using System;
class AvgGrade{
    public static void Main(){
        int x = 0;
        double total = 0, grade = 0, final = 0;
        while(!(grade == -1)){
            Console.WriteLine("Enter your grade. Enter -1 when you're done entering the grades.");
            grade = double.Parse(Console.ReadLine());
            total += grade;
            x += 1;
        }
        final = (total) / x;
        Console.WriteLine("The average for your grade is: " + final);
    }
}