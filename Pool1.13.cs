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
            int y1;int y2;int d = 0;
            Console.WriteLine("Scrie anul : ");
            y1 = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("Scrie anul : ");
            y2 = Convert.ToInt32(Console.ReadLine());
            for (int y = y1; y <= y2; y++)
            {
                if ((y % 4 == 0 && y % 100 != 0) || (y % 400 == 0))
                {
                    d++;
                }
                else
                {
                     
                }
            }
            Console.WriteLine("{0}  este an bisec", d);

        }
    }

    
}




        
    

