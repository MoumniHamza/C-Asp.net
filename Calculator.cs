using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Calculator
    {
        static void Main(string[] args)
        {
            Char firstChar = 'Q';
            bool keepRunning = true;

            do
            {
                Console.WriteLine();
                Console.Write("What would you like to do?(Add,Substract,Multiply,Divide,Quite)");
                string input = Console.ReadLine();
                firstChar = input[0];
                keepRunning = !(firstChar == 'q' || firstChar == 'Q');
                double firstNumber = 0;
                double secondNumber = 0;

                if (keepRunning)
                {
                    Console.Write("First Number :");
                    string firstnumberInput = Console.ReadLine();
                    firstNumber = double.Parse(firstnumberInput);
                    Console.Write("Second Number :");
                    string SecondnumberInput = Console.ReadLine();
                    secondNumber = double.Parse(SecondnumberInput);

                }
                double result = 0;
                switch (firstChar)
                {
                    case 'a':
                    case 'A':
                        result = firstNumber + secondNumber;
                        break;
                    case 's':
                    case 'S':
                        result = firstNumber - secondNumber;
                        break;
                    case 'M':
                    case 'm':
                        result = firstNumber * secondNumber;
                        break;
                    case 'd':
                    case 'D':
                        result = firstNumber / secondNumber;
                        break;
                    default:
                        result = -2;
                        break;
                }
                Console.WriteLine();
                Console.WriteLine("Your result is:" + result);

            } while (keepRunning);
        }
    }
}
