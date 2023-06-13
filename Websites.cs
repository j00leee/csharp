using System;
using System.Diagnostics;
class Websites {
    public static void Main() {
        string[] url = new string[3];

        for (int index = 0; index < url.Length; index++) {
            Console.WriteLine("Enter a url: ");
            url[index] = Console.ReadLine();
        }

        for (int index = 0; index < url.Length; index++)
            Process.Start("chrome.exe", url[index]);
    }
}