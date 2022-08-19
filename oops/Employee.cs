using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    internal class Employee
    {
        //private member variables
        int eid;
        string ename;
        float salary;
        //static int accept_count = 1;
        static int accept_count;
        static int disp_count = 1;

        public Employee()
        {
            eid = 10;
            ename = "Srimathi";
            salary = 10000;
        }

        static Employee()
        {
            accept_count = 1;
            //eid = 12; - require object to define non static members
            Employee e = new Employee();
            //e.eid = 20;
            Console.WriteLine(e.eid);
        }

        /*public Employee() - error because constructor with same parameter type
        {
            eid = 1;
            salary = 10000;
        }*/

        //Overloaded Constructor
        public Employee(float sal)
        {
            salary = sal;
        }

        public Employee(int eid, string ename, float salary)
        {
            this.eid = eid;
            this.ename = ename;
            this.salary = salary;
        }

        public Employee(int eid,float salary)
        {
            this.eid = eid;
            this.salary = salary;
        }

        public Employee(float salary,int eid)
        {
            this.eid = eid;
            this.salary = salary;
        }

        public void AcceptDetails()
        {
            Console.WriteLine("Enter details for employee "+accept_count+": ");
            Console.WriteLine("Enter eid,ename,salary");
            eid = Convert.ToInt32(Console.ReadLine());
            ename = Console.ReadLine();
            salary = float.Parse(Console.ReadLine());
            accept_count++;
        }

        public void DisplayDetails()
        {
            Console.WriteLine("Details of employee "+disp_count+": ");
            Console.WriteLine("Eid: " + eid);
            Console.WriteLine("Employee name: " + ename);
            Console.WriteLine("Employee salary: " + salary);
            disp_count++;
        }

        public static void calculate()
        {
            Employee emp = new Employee();
            Console.WriteLine(disp_count); //can directly access static variables in static method
            //Console.WriteLine(eid); // require an object to access non static variables inside static method
            Console.WriteLine(emp.eid);
        }

        ~Employee()
        {
            Console.WriteLine("Destructor is called");
        }

    }


    /*internal class Main
    {
        public static void Main()
        {
            Employee employee = new Employee();
            employee.AcceptDetails();
            employee.DisplayDetails();
        }

    }*/
}

    /*namespace oops
    {
        namespace abc
        {
            internal class Employee
            {
                //private member variables
                int eid;
                string ename;
                float salary;

                public void AcceptDetails()
                {
                    Console.WriteLine("Enter eid,ename,salary");
                    eid = Convert.ToInt32(Console.ReadLine());
                    ename = Console.ReadLine();
                    salary = float.Parse(Console.ReadLine());
                }

                public void DisplayDetails()
                {
                    Console.WriteLine("Eid: " + eid);
                    Console.WriteLine("Employee name: " + ename);
                    Console.WriteLine("Employee salary: " + salary);
                }

            }

        }*/
