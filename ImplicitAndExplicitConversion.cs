using System;
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
            int secondNumber3 = int.Parse(number2);// Explicitly converts a string to a number but inside the string needs to be a number
            Console.WriteLine(secondNumber3);
            Console.ReadLine();
            Console.WriteLine("Press enter to continue");

            string number3 = "na234";
            int secondNumber4 = int.Parse(number3);// This one fail because  parse only converts numbers inside a string
            Console.WriteLine(secondNumber4);
        }
    }


