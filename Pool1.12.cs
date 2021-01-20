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
            int y; int k = 0;int p=1;
            Console.WriteLine("n=");
            int n = Convert.ToInt32(Console.ReadLine()); Console.WriteLine("a=");
            int a = Convert.ToInt32(Console.ReadLine()); Console.WriteLine("b=");
            int b = Convert.ToInt32(Console.ReadLine());
            for (int i = a; i <= b; i++) 
            {
                if (n % i == 0) { k++; }

            }
            Console.WriteLine($"{k}numere sunt divizibile  int itervalul{a} si {b} ");
        }

    } 
}




        
    

