using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L9_RAMS_1018822
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int num=0;
                
                for (int i=2; i<=1000; i++)
                {
                    if (i%2==0)
                    {
                        num += i;
                    }
                }
                Console.WriteLine("La sumatoria de los números pares es: " + num);

            }
            catch
            {

            }
            Console.ReadKey();
        }
    }
}
