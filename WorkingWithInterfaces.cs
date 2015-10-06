using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication16
{


    interface I1
    {
        void Print();
    }

    interface I2
    {
        void Print();
    }

    public class LetsPrint: I1,I2
    {
        void I1.Print()
        {
            Console.WriteLine("I am interface I1");
        }

        void I2.Print()
        {
            Console.WriteLine("I am interface I2");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            LetsPrint print = new LetsPrint();
            ((I1)print).Print();
            ((I2)print).Print();
        }
    }
}
