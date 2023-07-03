using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment
{
    class person
    {
        //Create a class called Person and give it tow properties, each of data type string
        // One called FirstName, the other LastName
        public string FirstName { get; set; }
        public string LastName { get; set; }
      


        //Give the class a void method called SayName() that take no paratmeters and simples writes
        // the person's full name to the console in the format of: "Name: [full name]'
        public void SayName()
        {
            Console.WriteLine("Name: " + this.FirstName + "" + this.LastName);

        }
    }
}
