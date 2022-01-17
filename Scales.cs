/*
The program plays an audio frequency sound ascending to higher notes.
The program chooses a number from the audio frequency which is 20-20000 which is done by the 
Console.Beep command.
The program makes those sounds until the sound reaches to the greater than or equal to amount.
*/

using System;
class Scales{
    public static void Main(){
        for(int x = 100; x <= 10000; x += 10){
            Console.Beep(x, 1000);
        }
    }
}

/*
challenge

using System;
class Scale2{
    public static void Main(){
        Random g = new Random();
        int x = 0, y = 0;
        while(!(x >= 10)){
            y = g.Next(40, 10000);
            Console.Beep(y, 10000);
             x++;
        }
    }
}

*/