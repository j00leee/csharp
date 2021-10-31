/*
Asks the user a question and lets the user answer it
Displays the question to the user and the user answers it
If the user answers it right, display correct, but if wrong it displays "you
are wrong" with the correct answer
*/

using System;

class QuizQue{
    public static void Main(){
        string ans = "";

        Console.WriteLine("What is the slope intercept equation?: ");
        ans = Console.ReadLine();

        if(ans == "y=mx+b"){
            Console.WriteLine("Your response is correct");
        }
        else{
            Console.WriteLine("Sorry. The correct response is y=mx+b");
        }
    }
}
