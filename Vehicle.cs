using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// A vehicle program that interacts with the user input
namespace ConsoleApplication1
{
    class vehicle
    {
        public string model;
        public string manifacturer;
        public int numofdoors;
        public int price;
    }
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the properties of your car:");
            vehicle mycar = new vehicle();
            Console.Write("What is your car's model?:");
            string m = Console.ReadLine();
            mycar.model = m;
            Console.Write("What is your car's manifacturer?:");
            string n = Console.ReadLine();
            mycar.manifacturer = n;
            Console.Write("What is your car's numbers of doors?:");
            string t = Console.ReadLine();
            mycar.numofdoors = Convert.ToInt32(t);
            Console.Write("What is your car's price?:");
            string p = Console.ReadLine();
            mycar.numofdoors = Convert.ToInt32(p);
            Console.WriteLine("Here is your cars informations");
            Console.WriteLine("Model: " + mycar.model);
            Console.WriteLine("Manifacturer: " + mycar.manifacturer);
            Console.WriteLine("Number of doors: " + mycar.numofdoors);
            Console.WriteLine("Price: " + mycar.price);
            Console.WriteLine("Press enter to terminate");
            Console.ReadLine();




        }
    }
}
