using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btap3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double T = 0;
            for (int i =0;i<4;i++ )
            {
                T = 0;
                Console.WriteLine("i=" + i.ToString ());
                for (int j = 0; j < 3; j++)
                  
                {
                    Console.WriteLine("j=" + j.ToString());
                    T = T + i;
                    Console.WriteLine("T=" + T.ToString());
                }
            }
            Console.WriteLine("T=" + T.ToString());
        }
        //27-10 
    }
}
