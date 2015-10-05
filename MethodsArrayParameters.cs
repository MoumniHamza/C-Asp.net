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
            string[] Name = { "hamza", "moumni", "lina", "babydog" };
            Calculate(Name);
            Console.WriteLine(Name);
            Console.ReadLine();
            Console.WriteLine("Please enter to exit");
        }

        public static void Calculate(params string[] Names)
        {
            Console.WriteLine(" There is {0} names in your list: ", Names.Length);
            foreach (string name in Names)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();

        }
    }
}
