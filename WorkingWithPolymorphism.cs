using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication14
{

    class employee
    {
        public string firstName = "Hamza";
        public string lasName = "Moumni";

        public virtual void PrintName()
        {
            Console.WriteLine("Your name is " + firstName + " " + lasName);
            Console.ReadLine();
            Console.WriteLine("Press enter to exit");
        }
    }

    class partimeEmployee : employee
    {
        public override void PrintName()
        {
            Console.WriteLine("Your name is " + firstName + " " + lasName + " -You are a partime employee");
            Console.ReadLine();
            Console.WriteLine("Press enter to exit");
        }
    }

    class fulltimeEmployee : employee
    {
        public override void PrintName()
        {
            Console.WriteLine("Your name is " + firstName + " " + lasName + " -You are a fulltime employee");
            Console.ReadLine();
            Console.WriteLine("Press enter to exit");
        }
    }

    class temporaryEmployee : employee

    {
        public override void PrintName()
        {
            Console.WriteLine("Your name is " + firstName + " " + lasName + " -You are a temporary employee");
            Console.ReadLine();
            Console.WriteLine("Press enter to exit");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            employee[] name = new employee[4];
            name[0] = new employee();
            name[1] = new fulltimeEmployee();
            name[2] = new partimeEmployee();
            name[3] = new temporaryEmployee();

            foreach (employee e in name)
            {
                e.PrintName();
            }



        }
    }
}
