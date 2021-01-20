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
            Console.WriteLine("n=");
            double n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("k=");
            double k = Convert.ToInt32(Console.ReadLine());
            if(n%k==0)
            { Console.WriteLine("da se divide"); }
            else { Console.WriteLine("nu se divide"); }

        }


    }


}



        
    

