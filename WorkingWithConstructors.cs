using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApplication9
{
    class Customer
    {
        public string _firstName;
        public string _lastName;

        public Customer(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
        }

        public void printName()
        {
            Console.WriteLine("Hello My full name is : {0} ", _firstName + " " + _lastName);
            Console.ReadLine();
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Customer fullname = new Customer("Hamza", "Moumni");
            fullname.printName();

        }
    }
}