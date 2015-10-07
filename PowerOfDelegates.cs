using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication16
{
   
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader stream = new StreamReader(@"C:\Users\Mohamedhamza\Desktop\hamza.txt");
            Console.WriteLine(stream.ReadToEnd());
            Console.ReadLine();
            Console.WriteLine("Press enter to exit");
            stream.Close();
           
        }
        

    }
}
