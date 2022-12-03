using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("M = ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("N = ");
            int n = int.Parse(Console.ReadLine());
            int s = 0;
            for (int i = m; i <= n; i++)
            {
                s += i;
            }
            Console.Write("\nM = {0}; N = {1} -> {2}\n\n", m, n, s);

            Console.ReadKey();
        }
    }
}
