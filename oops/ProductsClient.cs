using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    internal class ProductsClient
    {
        public static void main()
        {
            List<Products> products = new List<Products>();
            products.Add(new Products(1, "pen", 34));
            products.Add(new Products(2, "pencil", 56));

            foreach (Products item in products)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
