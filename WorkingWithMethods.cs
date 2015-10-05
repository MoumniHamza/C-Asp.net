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
            Program p = new Program();
            p.EvenNumber();
        }

        public void EvenNumber()
        {
            int start = 0;
            while (start < 30)
            {
                Console.WriteLine(start);
                start = start +2;
                Console.ReadLine();
            }
            Console.WriteLine("Press enter to exit");
        }
    }
}
