/*
Opens a certain applciation the user wants
Asks the user to enter a number from 1-6
If the user enters 1, Microsoft Word opens up.
*/

using System;
using System.Diagnostics;

class Shortcutes{
    public static void Main(){
        string task = "";
        Console.WriteLine("Choose the user type you want to access from below: ");
        Console.WriteLine(" 1 - Document");
        Console.WriteLine(" 2 - Spreadsheet");
        Console.WriteLine(" 3 - Presentation");
        Console.WriteLine(" 4 - Web Browser");
        Console.WriteLine(" 5 - Drawing");
        Console.WriteLine(" 6 - Text editor");
        task = Console.ReadLine();

        if(task == "1"){
            Process.Start("winword.exe");
        }
        else if(task == "2"){
            Process.Start("excel.exe");
        }
        else if(task == "3"){
            Process.Start("powerpnt.exe");
        }
        else if(task == "4"){
            Console.WriteLine("Please select the browser type: ");
            Console.WriteLine(" 1 - Google Chrome");
            Console.WriteLine(" 2 - Microsoft Internet Explorer");
            task = Console.ReadLine();
            if(task == "1"){
                Process.Start("chrome.exe");
            }
            else if(task -- "2"){
                Process.Start("iexplore.exe");
            }
            else{
                Console.WriteLine("Invalid");
            }
        }
        else if(task == "5"){
            Process.Start("mspaint.exe");
        }
        else if(task == "6"){
            Process.Start("notepad.exe");
        }
        else{
            Console.WriteLine("Invalid Entry");
        }
    }
}