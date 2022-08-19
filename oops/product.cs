using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    internal class product
    {
        int pid;
        string pname;
        int quantity;
        int price;

        public int Pid
        {
            get
            {
                return pid;
            }
            set
            {
                if (value > 0)
                {
                    pid = value;
                }
                else
                {
                    pid = 0;
                }
            }
        }

        public string Pname
        {

            set
            {
                if(value != null)
                {
                    pname = value;
                }
                else
                {
                    pname = null;
                }
            }
            
        }

        public int Quantity
        {
            get; //read only
        }

        public int Price
        {
            get;
            set; //auto implemented
        }
    }

    

    class productclient
    {
        public static void main()
        {
            product p = new product();
            Console.WriteLine("Enter product id: ");
            p.Pid=Convert.ToInt32(Console.ReadLine());//set method called
            Console.WriteLine("pid: "+p.Pid);//get method called
            Console.WriteLine("Enter product name: ");
            p.Pname = Console.ReadLine();
            //Console.WriteLine(p.Pname); //- error because get accessor not given
            //p.Quantity = Convert.ToInt32(Console.ReadLine()); -  cannot get value from user because it is read only property
            Console.WriteLine(p.Quantity);
            Console.WriteLine(p.Price);
            Console.WriteLine("Enter price:");
            p.Price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(p.Price);
            
        }
    }
}
