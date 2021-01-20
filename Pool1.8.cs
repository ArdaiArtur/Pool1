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
            int y; int k = 0;
            Console.WriteLine("a=");
            double a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("b=");
            double b = Convert.ToInt32(Console.ReadLine());
            a = a + b;
            b = a - b;
            a = a - b;
           
            Console.WriteLine(a); Console.WriteLine(b);
        }

    }
}




        
    

