using System;
using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
        // Arithmetic operator
        int number1 = 200;
        int number2 = 300;
        int result = number2 % number1;
        Console.WriteLine("The result is: {0}", result);
        Console.ReadLine();
        Console.WriteLine("Press enter to continue");

        //  Conditional operator
        int number3 = 200;
        int number4 = 300;
        bool istrue = true;
        bool isfalse = false;

        if (number3 == 200 && number4 == 150)
        {
            Console.WriteLine("The result is: {0}", isfalse);
            Console.ReadLine();
            Console.WriteLine("Press enter to continue");
        }
        else
        {
            Console.WriteLine("The result is: {0}", istrue);
            Console.ReadLine();
            Console.WriteLine("Press enter to continue");
        }

        // Comparison operator
        int number5 = 200;
        int number6 = 300;
        bool istrue2 = true;
        bool isfalse2 = false;

        if (number5 > number6 )
        {
            Console.WriteLine("The result is: {0}", isfalse2);
            Console.ReadLine();
            Console.WriteLine("Press enter to exit");
        }
        else
        {
            Console.WriteLine("The result is: {0}", istrue2);
            Console.ReadLine();
            Console.WriteLine("Press enter to exit");
        }
    }
    }
   

