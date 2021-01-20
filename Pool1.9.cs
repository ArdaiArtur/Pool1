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
            Console.WriteLine("n=");
            double n = Convert.ToInt32(Console.ReadLine());
            for(int i=1;i<=n/2;i++)
            {
                if (n % i == 0) { Console.WriteLine(i); }

            }
        }
    }
}




        
    

