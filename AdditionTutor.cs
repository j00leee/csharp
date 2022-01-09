/*
The user is asked as many random addition math questions until he gets a score of 10 to earn the addition
badge.
Two random numbers are generated by the random g usage. The user is told to answer all questions until the 
user gets a score of 10. The number of questions asked to the user is being counted so that in the end
when it calculates the user's score, it can say "you got -number of questions- questions right."
When the user answers the question wrong, the computer displays the correct answer. If the user answers the 
question correctly, the computer keeps asking the user until the user reaches a score of 10. When the user 
reaches the score of ten, the computer displays that he earned the addition badge, and the average grade
of the number of questions that were asked to the user.
*/

using System;
class AdditionTutor{
    public static void Main(){
        int n1 = 0, n2 = 0, ans = 0, score = 0, numofques = 0;
        Random g = new Random();
        while(!(score == 10)){
            n1 = g.Next(1, 100);
            n2 = g.Next(1, 100);
            Console.WriteLine("What is " +n1 + " + " + n2 + " ?");
            ans = int.Parse(Console.ReadLine());
            numofques++;
            if(ans != n1 + n2){
                Console.WriteLine("Incorrect. " + n1 + " + " + n2 + " = " + (n1 + n2));
            }
            else{
                score++;
                Console.WriteLine("Correct.");
            }
        }
        Console.WriteLine("You got the Addition Badge.");
        Console.WriteLine("You got 10 questions correct out of " + numofques + " questions and your score is: " + (10.0 * 100 / numofques) + " %");
    }
}