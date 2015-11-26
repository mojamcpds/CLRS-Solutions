using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter01
{
    public class MergeSort
    {
        
        /// <summary>
        ///Recursive merge sort procedure to sort the subarray
        /// </summary>
        /// <param name="list">list containing the subarray to be sorted</param>
        /// <param name="p">Index of the beginning of the subarray</param>
        /// <param name="r">r Index of the end of the subarray</param>
        public void MergeSorting(List<int> list, int p, int r)
        {
            int q;
            if (p < r)
            {
                q = (p + r)/2;
                MergeSorting(list, p, q);
                MergeSorting(list, q + 1, r);
                Merge(list, p, q, r);
            }
        }

    
        /// <param name="list">Contains sub list to be merged</param>
        /// <param name="p">Beginning index of the first subarray</param>
        /// <param name="q">End indeex of the first subarray</param>
        /// Second subarray starts at index q+1
        /// <param name="r">end index of second sub array</param>
        public void Merge(List<int> list, int p, int q, int r)
        {
            var n = q - p + 1;
            var m = r - q;

            var left = new int[n + 1];
            var right = new int[m + 1];
            int i, j, k;

            for (i = 0; i < n; i++)
            {
                left[i] = list[p + i];

            }
            for (j = 0; j < m; j++)
            {
                right[j] = list[q + j+1 ];

            }

            left[n] = Int32.MaxValue;
            right[m] = Int32.MaxValue;

            i = 0;
            j = 0;
            for (k = p; k <= r; k++)
            {

                if (left[i] <= right[j])
                {
                    list[k] = left[i];
                    i = i + 1;
                }
                else
                {
                    list[k] = right[j];
                    j = j + 1;

                }

            }
        }

        public void PrintMergeSort(List<int> list)
        {
            Console.WriteLine("Sorting Result is:");
            foreach (var t in list)
            {
                Console.WriteLine(t.ToString());
            }
        }
    }
}
