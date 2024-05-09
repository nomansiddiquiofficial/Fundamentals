using static System.Runtime.InteropServices.JavaScript.JSType;
using System;

class Program
{
    static void Main(string[] args)
    {
        //  ternary operator
        //ex:1
        int speed = 100;
        string status = (speed > 80) ? "Above limit" : "Within limit";
        Console.WriteLine(status);

        //ex:2
        string time = (DateTime.Now.Hour < 12) ? "Morning" : "Afternoon";
        Console.WriteLine(time);

        //ex:3
        const double pi = 3.14;
         int number = int.Parse(Console.ReadLine());
        string result = (number > pi) ? "number is greater" : "number is lesser";
        Console.WriteLine(result);

        
    }
        
}