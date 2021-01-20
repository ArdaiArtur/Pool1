using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool1
{
    class Program
    {
        static void Main(string[] args)
        {
            int y; int k = 0; int p = 1;int x=0;
            Console.WriteLine("n=");
            int n = Convert.ToInt32(Console.ReadLine());
            y = n;
            while (y != 0)
            {
                k = y % 10;
                x = x + k * p;
                p = p * 10;
                y = y / 10;
            }
            if (x == n) { Console.WriteLine("palidrom"); }
            else Console.WriteLine(" nu palidrom");
        }
    } 
}




        
    

