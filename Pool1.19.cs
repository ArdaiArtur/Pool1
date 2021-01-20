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
            int  a = 0, b = 0, d;
            int n = Convert.ToInt32(Console.ReadLine());       
            a = n % 10;
            d = 1;
            while (n > 9)
            {
                n = n / 10;
                if ((n % 10 != a) && (d == 1))
                {
                    b = n % 10;
                    d = 2;
                }
                if ((d == 2) && (n % 10 != a) && (n % 10 != b))
                {
                    d++; Console.WriteLine(n % 10);
                }
            }
            if (d== 2) Console.WriteLine(" are  doar 2 cifre");
            else Console.WriteLine("nu are doar 2 cifre");
            Console.ReadKey();
        }
          
            
        }
}



    





        
    

