using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;

namespace Recursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> inputs = new List<int>() { 5, 10, 20 };
            var st = new Stopwatch();
            var fib = new Fibonacci();

            foreach (int i in inputs) 
            { 
                st.Start();
                int recFib = fib.RecursionFibonacci(i);
                st.Stop();
                Console.WriteLine($"Output: {recFib}");
                Console.WriteLine($"Recursion time (value = {i}): {st.Elapsed}");
                Console.WriteLine();

                st.Restart();

                st.Start();
                int cyclFib = fib.CycleFibonacсi(i);
                st.Stop();
                Console.WriteLine($"Output: {cyclFib}");
                Console.WriteLine($"Cycle time (value = {i}): {st.Elapsed}");
                Console.WriteLine();
            }
        }
    }
}
