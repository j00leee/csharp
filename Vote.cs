/*
Checks to see if the user can vote or not 
Tells the user to enter his/her age
If he is under 18, he can't vote, but if he's 18 or older, he can vote
*/

using System;

class Vote{
    public static void Main(){
        int age = 0;

        Console.WriteLine("Enter your age: ");
        age = int.Parse(Console.ReadLine());

        if(age >= 18){
            Console.WriteLine("You can vote");
        }
        else{
            Console.WriteLine("You can not vote");
        }
    }
}