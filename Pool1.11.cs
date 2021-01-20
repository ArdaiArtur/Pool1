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
            int n = Convert.ToInt32(Console.ReadLine());
            while (n != 0)
            {
                k = n %10;
                Console.WriteLine(k);
                n = n / 10;


            }
    }
    } 
}




        
    

