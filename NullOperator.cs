using System;
using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
        bool? graduate = true; // This is how you can give the bool a null value

        Console.WriteLine("Did you graduated :");
        string answer = Console.ReadLine();

        if (answer == "yes")
        {
            Console.WriteLine(graduate);
            Console.ReadLine();
            Console.WriteLine("Press enter to exit");
        }
        else if ( answer == "no")
        {
            graduate = false;
            Console.WriteLine(graduate);
            Console.ReadLine();
            Console.WriteLine("Press enter to exit");
        }
        else
        {
            Console.WriteLine("No answer was given");
            Console.ReadLine();
            Console.WriteLine("Press enter to exit");
        }
    }
    }
   

