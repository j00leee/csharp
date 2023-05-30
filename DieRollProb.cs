using System;
class DieRollProb{
    public static void Main(){
        int roll, one, two, three, four, five, six = 0;
        Random g = new Random();
        for (int x = 1; x <= 1000000; x++){
            roll = g.Next(1, 7);
            if (roll == 1) one++;
            else if(roll == 2) two++;
            else if(roll == 3) three++;
            else if(roll == 4) four++;
            else if(roll == 5) five++;
            else if(roll == 6) six++;
        }
        Console.WriteLine("# of \"1\"s:\t"+ one);
        Console.WriteLine("# of \"2\"s:\t"+ two);
        Console.WriteLine("# of \"3\"s:\t"+ three);
        Console.WriteLine("# of \"4\"s:\t"+ four);
        Console.WriteLine("# of \"5\"s:\t"+ five);
        Console.WriteLine("# of \"6\"s:\t"+ six);

    }
}