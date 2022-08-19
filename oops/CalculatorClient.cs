using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    internal class CalculatorClient
    {
        public static void main()
        {
            ICalculator c = new Casio();
            int sum = c.add(2,3);
            Console.WriteLine(sum);
            Casio c1 = new Casio();
            //Console.WriteLine(c.messages("Casio")); - error because ICalculator does not contain messages()
            Console.WriteLine(c1.messages("Casio"));
            c = new Flair();
            Console.WriteLine(c.message("Flair"));
        }
    }
}
