using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your target number: ");
            int target = int.Parse(Console.ReadLine()); //Convert the string to int

            int start = 0;
            while(start<target)
            {
                Console.WriteLine(start);
                start = start + 2;  // increment the variable by 2
                Console.ReadLine();

            }
            Console.WriteLine("Press enter to exit");
        }
    }
}
