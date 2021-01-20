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
        { int y;
            Console.WriteLine("Scrie anul : ");
            y = Convert.ToInt32(Console.ReadLine());

           if ((y % 4 == 0 && y % 100 != 0) || (y % 400 == 0))
            {
                Console.WriteLine("{0} an bisect", y);
            }
            else
            {
                Console.WriteLine("{0} nu este an bisec", y);
            }
           
        }
        


    }


}



        
    

