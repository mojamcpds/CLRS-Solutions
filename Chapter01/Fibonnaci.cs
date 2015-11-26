using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter01
{
    public class Fibonnaci
    {
        public void FibonnaciSeries()
        {

            Console.WriteLine("Enter the Length of the Fibonnaci Series");
            var n = Convert.ToInt32(Console.ReadLine());

            int a = 0, b = 1, c = 0;

            Console.WriteLine("Your Fibonnaci numbers are: ");
            Console.Write("{0} {1}", a, b);
            
            for (var i = 2; i < n; i++)
            {
                c = a + b;
                Console.Write(" {0}", c);
                a = b;
                b = c;
            }
        }

        
    }

    public static class ResizeList
    {
        //    list: List<T> to resize
        //    size: desired new size
        // element: default value to insert

        public static void Resize<T>(this List<T> list, int size, T element = default(T))
        {
            int count = list.Count;

            if (size < count)
            {
                list.RemoveRange(size, count - size);
            }
            else if (size > count)
            {
                if (size > list.Capacity)   // Optimization
                    list.Capacity = size;

                list.AddRange(Enumerable.Repeat(element, size - count));
            }
        }
    }
}
