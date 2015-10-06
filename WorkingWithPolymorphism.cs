using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication14
{
    class student

    {
        string _name;
        string _id;
        string _score;
        
        public void getName(string name)
        {
            if(name == "")
            {
                throw new Exception("Please enter a valid name");
            }
            this._name = name;
        }

        public string SetName(string name)
        {
            return this._name;
        }

        public void PrintName()
        {
            Console.WriteLine("Your name is : {0}", SetName("hamza"));
        }
    }
   
    class Program
    {
        static void Main(string[] args)
        {
            student name = new student();
            name.PrintName();


        }
    }
}
