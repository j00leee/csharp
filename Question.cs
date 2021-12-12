/*
The user is given a question and the user has a limited amount of tries to answer the
question correctly.
The question, "What is today's day?" is asked to the user. Every time the user doesn't answer
correctly, the questioned is repeated up to 5 times. If the user gets it right in less than 5 
times, the question stops asking the user.
When the user answers the question 5 times, the computer stops asking the user the question
and displays that the user answered the question 5 times. If the user got it right without
reaching the max number of tries, the computer tells the user that they answered the 
question in the amount of tries until they got it right.
*/

using System;
class Question{
    public static void Main(){
        int attempts = 1;
        string answer = "";
        while(!(answer == "saturday" || attempts > 5)){
            Console.WriteLine("What is today's day?");
            answer = Console.ReadLine();
            attempts = attempts + 1;
        }
        if(attempts > 5) Console.WriteLine("Maximum number of attempts used up.");
        else Console.WriteLine("You got it right in " + (attempts - 1) + " tries.");
    }
}