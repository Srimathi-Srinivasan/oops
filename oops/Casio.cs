using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    internal class Casio : ICalculator
    {
        public int add(int x, int y)
        {
            return x  + y;
        }

        public int div(int x, in int y)
        {
            return x / y;
        }

        public int mul(int x, in int y)
        {
            return x * y;
        }

        public int sub(in int x, in int y)
        {
            return x - y;
        }

        //string override message(string companyname) - cannot override in interface
        //{
        //    return "Hello " + companyname;
        //}

        public string messages(string companyname)
        {
            return "Hello " + companyname;
        }
    }
}
