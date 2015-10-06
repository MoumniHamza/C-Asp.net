using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication16
{
    class employee
    {
        public string name { get; set; }
        public int id { get; set; }
        public int salary { get; set; }
        public int experience { get; set; }
        public static void promotion(List<employee> employed, AmIPromoted promoted)
        {
            foreach (employee e in employed)
            {
                if (promoted(e))
                {
                    Console.WriteLine(e.name);
                }
            }
        }
    }

    delegate bool AmIPromoted(employee emp);
    class Program
    {
        static void Main(string[] args)
        {
            List<employee> employees = new List<employee>();
            employees.Add(new employee() { name = "Hamza", experience = 5, id = 101, salary = 7000 });
            employees.Add(new employee() { name = "Bob", experience = 14, id = 102, salary = 71000 });
            employees.Add(new employee() { name = "ahmed", experience = 2, id = 103, salary = 2000 });
            employees.Add(new employee() { name = "lina", experience = 4, id = 104, salary = 5000 });

            AmIPromoted promoted = new AmIPromoted(promote);

            employee.promotion(employees, promoted);
        }
        public static bool promote(employee emp)
        {
            if (emp.experience >= 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
