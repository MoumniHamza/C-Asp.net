using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            int total2 = 0;
            Calculate(23, 24, out total, out total2);
            Console.WriteLine("Our total1 is : {0} , and out totla2 is:{1}", total, total2);
            Console.ReadLine();
            Console.WriteLine("Press enter to exit");
        }

        public static void Calculate(int fn, int sn, out int sum, out int product)
        {
            sum = fn + sn;
            product = fn * sn;

        }
    }
}
