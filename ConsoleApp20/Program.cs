using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment

{
    class Program
    {
        static void Main(string[] args)
        {
            //Inside of the Main method, instantiate and initialize an Employee object with
            //the first name "Sample" and the last name "Student" 
            employee employee = new employee() { FirstName = "Ali", LastName = "Samim"  };
            employee sam = employee;
            //Call the superclass method SayName() on the Employee object
            sam.SayName();
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
