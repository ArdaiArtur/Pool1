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
            Console.WriteLine("a=");
            double a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("b=");
            double b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("c=");
            double c = Convert.ToInt32(Console.ReadLine());
            double ux=0; double dx = 0; double dta;
            Console.WriteLine(" cere ca axpow2+bx+c=0");
            if(a!=0)
            {
                dta = Math.Pow(b,2) - 4 * c * a;
                   if(dta<0) Console.WriteLine("nu exista");
                if (dta==0)
                {
                    ux=-b/2*a; Console.WriteLine(ux);
                }
                    else
                {
                    ux = (-b - Math.Sqrt(dta)) / 2*a;
                    dx= (-b + Math.Sqrt(dta)) / 2 * a;
                    Console.WriteLine("1x=");
                    Console.WriteLine(ux); 
                    Console.WriteLine("2x=");
                    Console.WriteLine(dx);
                }
            }
            else
            {
                ux = -b / c;

                Console.WriteLine("x=");
                Console.WriteLine(ux);

            }
            
           




        }
    }
}
