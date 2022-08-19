using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    internal class ExceptionsEg
    {
        public static void main()
        {
            int c = 0;
            int d = 0;
            try
            {
                Console.WriteLine("Enter two numbers: ");
                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());
                
                c = a + b;
                d = a / b;
                
            }
            catch(FormatException)
            {
                Console.WriteLine("Inputs must be only numbers");
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("Second Number cannot be zero");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("sum: " + c);
                Console.WriteLine(d);
            }
            
        }
    }
}
