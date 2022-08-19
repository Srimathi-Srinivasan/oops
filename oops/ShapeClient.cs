using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    internal class ShapeClient
    {
        public static void main()
        {
            //Shape s = new Shape();
            //s.AcceptDetails();
            //s.DisplayDetails();

            //Rectangle r = new Rectangle();
            //r.AcceptDetails();
            //r.CalculateArea();
            //r.DisplayDetails();

            //Circle c = new Circle();
            //c.AcceptDetails();
            //c.CalculateArea();
            //c.DisplayDetails();

            //Shape s = new Rectangle(); // dynamic polymorphism
            //s.AcceptDetails(); //calls overridden child class
            //s.CalculateArea();
            //s.DisplayDetails();

            //s = new Circle();
            //s.AcceptDetails();
            //s.CalculateArea();
            //s.DisplayDetails();

            Shape s = new Rectangle();
            s.AcceptDetails();
            s.CalculateArea();
            s.DisplayDetails();
            

            s = new Circle();
            s.AcceptDetails();
            s.CalculateArea(); //calls base class calculate area since a new method is defined 
            s.DisplayDetails();

        }
    }
}
