/*
The computer chooses a random number from 1-100 and the user have to guess the number.
The user is told to guess a number from 1 to 100. If the user doesn't get it right and is less
than the random number, the user is told to guess higher. However. if the user guesses it wrong 
and is higher than the random number, the user is told to guess lower.
If the user guesses the number correctly, then the computer tells the user that he got it right in a 
specific amount of tries he guessed.
*/

using System;
class GuessingGame{
    public static void Main(){
        int x = 0, attempts = 1, user = 0;
        Random g = new Random();
        x = g.Next(1, 101);
        while(!(user == x)) {
            Console.WriteLine("Guess a number from one to hundred.");
            user = int.Parse(Console.ReadLine());
            attempts += 1;
            if (user < x){
                Console.WriteLine("Guess higher");
            }
            else if(user > x){
                Console.WriteLine("Guess lower");
            }
            else{
                Console.WriteLine("You got it right in " + (attempts - 1) + " tries.");
            }
        }
    }
}