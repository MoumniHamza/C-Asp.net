﻿using System;
using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {

        // This is an explicit conversion from int to float because there is no loss in value along the conversion
        int number = 200;
        float secondNumber = number;
        Console.WriteLine(number);
        Console.ReadLine();
        Console.WriteLine("Press enter to continue");

        // The following will fail because we will need to do an explicit conversion
        //float number = 200.45;
        //int secondNumber = number;
        //Console.WriteLine(secondNumber);
        //Console.ReadLine();
        //Console.WriteLine("Press enter to continue");


        float number1 = 200.456F;
        int secondNumber2 = (int)number1;//Explicitly converted int to float using the cast method
        Console.WriteLine(secondNumber2);
        Console.ReadLine();
        Console.WriteLine("Press enter to continue");

        string number2 = "220";
        int secondNumber3 = int.Parse(number2);
        Console.WriteLine(secondNumber3);
        Console.ReadLine();
        Console.WriteLine("Press enter to continue");

    }
    }
   

