using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    public class Fibonacci
    {
        public int RecursionFibonacci(int n)
        {
            if (n == 0 || n == 1) return n;

            return RecursionFibonacci(n - 1) + RecursionFibonacci(n - 2);
        }
        public int CycleFibonacсi(int n)
        {
            int result = 0;
            int x = 1;
            int tmp;

            for (int i = 0; i < n; i++)
            {
                tmp = result;
                result = x;
                x += tmp;
            }

            return result;
        }
    }
}
