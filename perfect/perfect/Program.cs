using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace perfect
{
    internal class Program
    {
        static bool perfect(int number)
        {
            int sum = 0;    
            for(int x=1;x<number;x++) 
            { 
                if(number%x==0) sum=sum+x;
            }
            if(sum ==number)return true;
            return false;   
        }
        static void Main(string[] args)
        {
            int x, y;
            Console.WriteLine("enter the number : ");
            x= int.Parse(Console.ReadLine());
            Console.WriteLine("enter the number : ");
            y= int.Parse(Console.ReadLine());



            Console.WriteLine("\n");
            for(int i= x; i<=y; i++) 
            {
                if (perfect(i)) Console.WriteLine("{0},", i);
            }
            Console.ReadKey();
        }
    }
}
