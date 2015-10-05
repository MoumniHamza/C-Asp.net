using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication13
{   
    public class Employee
    {
        public string _firstName;
        public string _lastName;
        public void Print()
        {
            Console.WriteLine("The employees name is : " + this._firstName + this._lastName);
        }
        
    }

    class FulltimeEmployee : Employee
    {
        public new void Print()
        {
            Console.WriteLine("The employees name is : " + this._firstName + " "+ this._lastName + " -full time Benefits");
            Console.ReadLine();
            Console.WriteLine("Press enter to exit");
        }
    }

    class ParttimeEmployee : Employee
    {
        
    }

    class Program
    {
        static void Main(string[] args)
        {
            FulltimeEmployee employee = new FulltimeEmployee();
            employee._firstName = "Hamza";
            employee._lastName = "Moumni";
            employee.Print();
        }
    }
}
