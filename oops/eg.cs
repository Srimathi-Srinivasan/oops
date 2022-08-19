using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    internal class eg
    {
        public eg()
        {
            Console.WriteLine("Constructor called");
        }

        ~eg()
        {
            Console.WriteLine("Destructor called");
        }

    }

    internal class Vehicle
    {
        public string color;
        protected void Color()
        {            
            Console.WriteLine("enter color: ");
            color = Console.ReadLine();
        }
    }

    class Car: Vehicle
    {
        string model;
        protected void Color()
        {
            base.Color();
        }

        public void method()
        {
            base.Color();
        }
        
        
    }
    internal class program
    {
        public static void main()
        {
            eg e = new eg();
            Car c = new Car();
            c.method();

        }
    }
}
