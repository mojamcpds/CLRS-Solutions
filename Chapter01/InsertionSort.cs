using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter01
{

    //For better Optimization please check the link:https://code.google.com/p/clrs-examples/source/browse/src/ca/jvsh/algorithm/Algorithms.java?r=7ecedd94139b1dc161fcac057cb4989db6bb6478

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

        public void PrintInsertionSort()
        {
            Console.WriteLine("Insertion Sort Example");

            var list = new List<int>();

            Console.WriteLine("Please Enter the number of elements");
            var n = Convert.ToInt32(Console.ReadLine());

            for (var i = 0; i < n; i++)
            {
                Console.WriteLine("Enter Elemennt " + (i + 1).ToString());
                var sortableElement = Convert.ToInt32(Console.ReadLine());
                list.Add(sortableElement);
            }

            InsertionSorting(list, list.Count());

            Console.WriteLine("The output is :");
            foreach (var t in list)
            {
                Console.WriteLine(t);
            }
        }
    }
}
