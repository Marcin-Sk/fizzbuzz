using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fizzbuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                string A = "";

                if (i % 3 == 0)
                {
                    A += "Fizz";
                }

                if (i % 5 == 0)
                {
                    A += ((A != "" )? " " : "") + "Buzz";
                }

                if (A == "")
                {
                    A += i;
                }

                Console.WriteLine(A);

            }

            Console.ReadLine();
        }
    }
}
