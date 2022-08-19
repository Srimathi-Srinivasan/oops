using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    internal interface ICalculator
    {
        int add(int x, int y);
        int sub(in int x, in int y);
        int mul(int x, in int y);
        int div(int x, in int y);
        string message(string companyname)
        {
            return "Hi " + companyname;
        }
    }
}
