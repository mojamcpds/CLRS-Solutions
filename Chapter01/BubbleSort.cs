using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter01
{
    public class BubbleSort
    {
        public void PrintBubbleSort()
        {
            Console.WriteLine("Bubble Sort Example");

            var data = new List<int>();
            Console.WriteLine("Please Enter the number of elements");
            var n = Convert.ToInt32(Console.ReadLine());

            for (var i = 0; i < n; i++)
            {
                Console.WriteLine("Enter Elemennt " + (i + 1).ToString());
                var sortableElement = Convert.ToInt32(Console.ReadLine());
                data.Add(sortableElement);
            }

            BubbleSorting(data, n);

            Console.WriteLine("Bubble Sorting Result");
            foreach (var t in data)
            {
                Console.WriteLine(t);
            }
        }

        private int _temp;
        private void BubbleSorting(List<int> data, int size)
        {
            for (var i = 0; i < size; i++)
            {
                for (var j = 0; j < size - 1; j++)
                {
                    if (data[j] <= data[j + 1]) 
                        continue;
                    
                    _temp = data[j];
                    data[j] = data[j + 1];
                    data[j + 1] = _temp;
                }
            }
        }

       

    }
}
