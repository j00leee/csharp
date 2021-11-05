/*
Check to see if there's a hashtag and removes the comment
Asks the user to enter some kind of code and searches for "#"
If "#" is present, it removes the comment, if it's not present but the comment is present,
the comment just stays
*/

using System;

class CommentRemoval{
    public static void Main(){
        string code = "", c1 = "";
        int pos = 0;

        Console.WriteLine("Please enter the code: ");
        code = Console.ReadLine();
        pos = code.IndexOf('#');

        if(pos == -1){
            Console.WriteLine(code);
        }
        else{
            c1 = code.Substring(0, pos);
            Console.WriteLine(c1);
        }
    }
}