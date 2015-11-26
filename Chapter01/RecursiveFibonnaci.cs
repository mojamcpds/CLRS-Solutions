using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter01
{
    public class RecursiveFibonnaci
    {
        private int FibonnaciRecursive(int n)
        {
            if (n == 0) 
                return 0; //To return the first Fibonacci number   
            if (n == 1) 
                return 1; //To return the second Fibonacci number   

            return FibonnaciRecursive(n - 1) + FibonnaciRecursive(n - 2);
        }

        public void PrintRecursiveFibonnaci()
        {
            Console.WriteLine("Enter the Length of the Fibonnaci Series");
            var n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Fibonnaci Numbers are:");
            for (var i = 0; i < n; i++)
            {
                Console.Write("{0} ", FibonnaciRecursive(i));
            }  
        }
    }
}
