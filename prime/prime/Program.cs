using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number :");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            for (int x = num1; x <= num2; x++)
            {
                bool isprime = true;
                for (int y = 2; y < x; y++)
                {
                    if (x % y == 0)
                    {

                        isprime = false;
                        break;

                    }


                }
                if (isprime)
                {
                    Console.WriteLine(" is prime : " + x);
                }
            }
        }
    }
}
