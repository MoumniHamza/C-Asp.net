using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculateAverage("my phone", "your phone", 1400, 1250);
            CalculateAverage(1400, 1250);
            Console.WriteLine("Type enter to exit");
            Console.ReadLine();
        }
        public static void CalculateAverage(string s1, string s2, double d1,double d2)
        {

            double average = (d1 + d2) / 2;
            Console.WriteLine();
            Console.WriteLine("The average of  " + s1 +" whose value is " + d1 +" and the average of " + s2 +" whose value is " + d2 +" is " + average);
        }
        public static void CalculateAverage(double d1, double d2)
        {
            double average = (d1 + d2) / 2;
            Console.WriteLine("The average of :" + d1 + " and :" + d2 + "is equal to " + average);
        }
    }
}
