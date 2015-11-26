using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter01
{
    public class InsertionSort
    {
        public void InsertionSorting(List<int> pp, int size)
        {
            for (var i = 0; i < size; i++)
            {
                var key = pp[i];
                var j = i - 1;
                while (j >= 0 && key < pp[j])
                {
                    pp[j + 1] = pp[j];
                    j--;
                }
                pp[j + 1] = key;
            }
        }

        public void PrintInsertionSort(List<int> pp, int size)
        {
            Console.WriteLine("\n");
            Console.WriteLine("The Sorting Result is:");
            for (var i = 0; i < size; i++)
            {
                System.Console.WriteLine(pp[i]);
            }
        }
    }
}
