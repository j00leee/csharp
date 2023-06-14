using System;
class GradeArray {
    public static void Main() {
        int sum = 0, x = 0;
        string[] input = System.IO.File.ReadAllLines("grades.txt");
        Console.WriteLine("The grades are:\n ");
        for (int index = 0; index < input.Length; index++) {
            Console.WriteLine(input[index]);
            if (int.Parse(input[index]) >= 65) x++;
            sum += int.Parse(input[index]);
        }
        Console.WriteLine("Average: " + sum * 1.0 / input.Length);
        Console.WriteLine("Number of passing grades: " + x);
    }
}