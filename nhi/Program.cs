using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace nhi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" Nhap vao so tu nhien n : ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] A = new int[n];
            Double T = 0;
            for (int i = 1; i < n; i++)
            {
               T = 0;
                Console.WriteLine("i=" + i.ToString());
                for (int j = 1; j < n; j++)

                    //20-10// 
                {
                    Console.WriteLine("  j=" + j.ToString());
                    T = T + j;
                }
            }
            Console.ReadLine();
               
        }
    }
}
