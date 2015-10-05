using System;
using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
        
        int FinalBill = 0;
        start:  // this is a label
        Console.WriteLine("Welcome to our Coffeshop, this is what we serve , what would you like to drink ");
        Console.WriteLine("1- Cappucino, 2- Latte, 3-Expresso");
        Console.WriteLine("When you are ready press the number of your choice");
        int choice = int.Parse(Console.ReadLine()); // I convert it to integer

        switch(choice)
        {
            case 1:
                FinalBill += 3;
                break;
            case 2:
                FinalBill += 4;
                break;
            case 3:
                FinalBill += 5;
                break;
            default:
                Console.WriteLine("Sorry {0} is not a valid choice ", choice);
                break;
        }
        tryagain: // this is a label
        Console.WriteLine(" Would you like to buy something else? yes/no");
        string decision = Console.ReadLine();

        switch(decision.ToUpper())
        {
            case "YES":
                goto start;
            case "NO":
                break;
            default:
                Console.WriteLine("sorry {0} is not a valid answer, try again", decision);
                goto tryagain;
        }

        Console.WriteLine("Thank you for your purchase your bill is : {0}", FinalBill);
        Console.ReadLine();
        Console.WriteLine("press enter to exit");
    }
    }
   

