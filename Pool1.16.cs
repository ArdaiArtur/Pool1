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
            
            int[] v = new int[5];
            for (int i = 0; i < 5; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
            }
           
            for (int i = 0; i < 4; i++)
            {
                for (int j = i + 1; j < 5; j++)
                {
                    if (v[i] > v[j])
                    {
                        int b;
                        b = v[i];
                        v[i] = v[j];
                        v[j] = b;
                    }
                }
            }
          
            for (int i = 0; i < 5; i++)
            {
                Console.Write(v[i] + " ");
            }
           
        }

    } 
}




        
    

