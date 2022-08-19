using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    class AgeNotValidException:ApplicationException
    {
        //base class initialization

        public AgeNotValidException(string message) : base(message) 
        {
        
        }
    }

    public class Voting
    {
        public int Age { get; set; }

        public void CheckAge()
        {
            Console.WriteLine("Enter the Age: ");
            Age = Convert.ToInt32(Console.ReadLine());
            if (Age < 18)
            {
                throw new AgeNotValidException("Sorry you are not eligible to vote!");
            }
            else
            {
                Console.WriteLine("Thanks for voting!");
            }
        }
    }
    internal class VotingClient
    {
        public static void main()
        {
            Voting v = new Voting();
            try
            {
                v.CheckAge();
            }
            catch(AgeNotValidException e)
            {
                Console.WriteLine(e.Message);
            }
        }

    }
}
