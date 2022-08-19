using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    internal class Flair : ICalculator
    {
        public int add(int x, int y)
        {
            return x + y + 5;
        }

        public int div(int x, in int y)
        {
            return (x - y) / 2;
        }

        public int mul(int x, in int y)
        {
            return x * y;
        }

        public int sub(in int x, in int y)
        {
            return x - y;   
        }
    }
}
