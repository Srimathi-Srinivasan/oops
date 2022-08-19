using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    abstract class Shape
    {
        public string color { get; set; }
        protected float area;

        public virtual void AcceptDetails()
        {
            Console.WriteLine("Enter color: ");
            color = Console.ReadLine();
        }

        public virtual void DisplayDetails()
        {
            Console.WriteLine("color: " + color);
            Console.WriteLine("Area: " + area);
        }

        public abstract void CalculateArea();

        
    }

    class Rectangle :Shape 
    {
        int length, breadth;
        
        public override void AcceptDetails()
        {
            Console.WriteLine("Enter length and breadth: ");
            length = Convert.ToInt32(Console.ReadLine());
            int.TryParse(Console.ReadLine(), out breadth);
            base.AcceptDetails();
        }
        public override void CalculateArea()
        {
            
            area = length * breadth;
        }
        /*public void DisplayDetails()
        {
            Console.WriteLine("Length: "+length);
            Console.WriteLine("Breadth: "+breadth); - no error but base class method is not overridden instead a new method is created 
            Console.WriteLine("Area: "+area);
        }*/

        public override void DisplayDetails()
        {
            Console.WriteLine("Length: "+length);
            Console.WriteLine("Breadth: "+breadth); 
            Console.WriteLine("Area: "+area);
        }
    }

    class Circle:Shape
    {
        int radius;
        public override void AcceptDetails()
        {
            Console.WriteLine("Enter radius: ");
            radius = Convert.ToInt32(Console.ReadLine());
        }

        public override void CalculateArea()
        {
            area =float.Parse((3.14 * radius * radius).ToString());
        }

        public override void DisplayDetails()
        {
            Console.WriteLine("Area: "+area);
        }

    }
}
