/*
Check what letter grade the user got
Asks the user for a grade then informs the user the letter grade
If the grade is 90-100, the user's letter grade is E.
75 - 89: S, 65-74: N, 64 or below: U
*/

using System;

class LetterGrades{
    public static void Main(){
        int grade = 0;
        Console.WriteLine("Please enter your grade: ");
        grade = int.Parse(Console.ReadLine());

        if(grade >= 90 && grade <= 100){
            Console.WriteLine("Your letter grade is E");
        }
        else if(grade >= 75 && grade <= 89){
            Console.WriteLine("Your letter grade is S");
        }
        else if(grade >= 65 && grade <= 74){
            Console.WriteLine("Your letter grade is N");
        }
        else if(grade <= 64 && grade >= 0){
            Console.WriteLine("Your letter grade is U");
        }
        else{
            System.Windows.Forms.MessageBox.Show("Invalid grade.");
        }
    }
}