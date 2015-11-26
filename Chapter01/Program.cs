using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter01
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Insertion Sorting

            //var insertionSort = new InsertionSort();
            //var list = new List<int>();
            //Console.WriteLine("Please Enter the number of elements");
            //var n = Convert.ToInt32(Console.ReadLine());

            //for (var i = 0; i < n; i++)
            //{
            //    var sortableElement = Convert.ToInt32(Console.ReadLine());
            //    list.Add(sortableElement);
            //}

            //insertionSort.InsertionSorting(list, list.Count());
            //insertionSort.PrintInsertionSort(list,list.Count());

            #endregion

            #region Merge Sorting
            var mergeSort = new MergeSort();
            var list = new List<int>();
            Console.WriteLine("Please Enter the number of elements");
            var n = Convert.ToInt32(Console.ReadLine());

            for (var i = 0; i < n; i++)
            {
                var sortableElement = Convert.ToInt32(Console.ReadLine());
                list.Add(sortableElement);
            }

            mergeSort.MergeSorting(list, 0,list.Count()-1);
            mergeSort.PrintMergeSort(list);
            #endregion

            Console.ReadKey();


        }
    }
}
