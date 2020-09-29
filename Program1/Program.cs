using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Средний
            try
            {
                double N, m, y;
                Console.Write("введите m:");
                m = double.Parse(Console.ReadLine());
                Console.Write("введите y:");
                y = double.Parse(Console.ReadLine());
                N = (m * m + 2.8 * m + 0.355) / (Math.Cos(2 * y) + 3.6);
                Console.WriteLine("N=" + N);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
