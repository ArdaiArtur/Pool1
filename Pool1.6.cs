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
            Console.WriteLine("c=");
            double c = Convert.ToInt32(Console.ReadLine());
          
            if(Math.Pow(a,2)<2*(Math.Pow(b,2)+Math.Pow(c,2)))
            { Console.WriteLine("a,b,c sunt lungimile laturilor unui triunghi."); }
            else { Console.WriteLine("a,b,c nu sunt lungimile laturilor unui triunghi."); }


        }

    }
}




        
    

