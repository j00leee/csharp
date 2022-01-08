/*
The user gets to choose either of the 2 lottery over the course of a year.
The device caluclates how much money the user will get when he chooses a lottery. Lottery 1 
payouts an initial amount of $10000 and then $1000 every week afterwards. Lottery 2 doubles the 
amount of money the user gets at the end of each day.
Output: Therefore, lottery 2 is better because the user will get more money than in lottery 1.
*/

using System;
class BetterLottery{
    public static void Main(){
        double day = 1, lot2 = 1, lot1 = 0;
        lot1 = 10000 + (52 * 1000);
        while(!(day == 365)){
            day++;
            lot2 += day;
        }
        if(lot2 > lot1){
            Console.WriteLine("Lot2 is better and you get: $" + lot2);
        }
    }
}