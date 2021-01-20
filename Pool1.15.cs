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
            int y; int k = 0; int p = 1;
            Console.WriteLine("c=");
            int c = Convert.ToInt32(Console.ReadLine()); Console.WriteLine("a=");
            int a = Convert.ToInt32(Console.ReadLine()); Console.WriteLine("b=");
            int b = Convert.ToInt32(Console.ReadLine());
            if (a > b) { k = a; a = b;b = k; }
            if (b > c) { k = b;b = c;c = k; }
            if (a > b) { k = a;a = b;b = k; }
            Console.WriteLine($"{a},{b},{c}");
        }

    } 
}




        
    

