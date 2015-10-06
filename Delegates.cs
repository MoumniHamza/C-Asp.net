using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication16
{
    public delegate void delegatefunction(string name);

    class Program
    {
        static void Main(string[] args)
        {
            delegatefunction name = new delegatefunction(function);
            {
                name("My name is hamza");
            }


        }

        public static void function(string name)
        {
            Console.WriteLine(name);
        }
    }
}
