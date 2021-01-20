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
            Console.WriteLine("n=");
            int n = Convert.ToInt32(Console.ReadLine()); 
            for(int i=2;i<=n;i++)
            { while(n % i == 0) { k++;n = n / i; }

                if(k!=0)Console.WriteLine($"{i}^{k}");
                k = 0;
            }
            
        }

    } 
}




        
    

