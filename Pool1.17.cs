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


            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            while (a != b)
            {
                if (a > b) a = a - b;
                else b = b - a;
            }
            Console.WriteLine("cel mai mare este " + a);

            Console.ReadKey();
        }
          
            
        }
}



    





        
    

