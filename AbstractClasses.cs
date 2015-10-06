using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication16
{
    public abstract class customer
    {
        public abstract void name();
    }

    public class customername : customer
    {
        public override void name()
        {
            Console.WriteLine("What is your name");
            string name = Console.ReadLine();
            Console.WriteLine("Welcome, {0} , you are part of the class customer", name);
            Console.ReadLine();
            Console.WriteLine("Press enter to exit");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            customer C = new customername();
            C.name();
        }
    }
}
