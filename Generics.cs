using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication20
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isequal = Equality.Equal<string>("A", "2");
            if(isequal)
            {
                Console.WriteLine("It is equal");

            }
            else
            {
                Console.WriteLine("It is not equal");
            }
            Console.ReadLine();
            Console.WriteLine("Press enter to exit");
        }

    class Equality
        {
            public static bool Equal<T>(T number, T number1)
            {
                return number.Equals(number1);
            }
        }
    }
}
