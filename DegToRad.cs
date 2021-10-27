/*
Create a program to convert an angle measure from degrees to radians.
radians = degrees * pi / 180
*/

using System;

class DegToRad{
    public static void Main(){
        int deg;
        double rad;

        deg = 360;
        rad = 0;

        rad = deg * 3.14 / 180;

        Console.WriteLine(deg + "degrees = " + rad + "radians");
    }
}