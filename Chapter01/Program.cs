﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter01
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            Console.WriteLine("Enter algorithm demo number");
            Console.WriteLine("1 - Insertion Sort");
            Console.WriteLine("2 - Merge Sort");
            Console.WriteLine("3 - Bubble Sort");

            var algorithm = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Entered " + algorithm);

            switch (algorithm)
            {
                case 1:
                    new InsertionSort().PrintInsertionSort();
                    break;
                case 2:
                    new MergeSort().PrintMergeSort();
                    break;
                case 3:
                    new BubbleSort().PrintBubbleSort();
                    break;

                default:
                    Console.WriteLine("No such algorithm");
                    break;
            }

            Console.ReadKey();


        }
    }
}
