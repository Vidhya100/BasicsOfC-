using System;

namespace Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //BoxingUnBoxing bu = new BoxingUnBoxing();
            //bu.Boxing();

            //delegates d = new delegates();
            //d.delegatesE();

            //------------------for heap-------------------
            int[] arr = { 55, 25, 89, 34, 12, 19, 78, 95, 1, 100 };
            int n = 10, i;

            Console.WriteLine("Heap Sort");
            Console.Write("Initial array is: ");
            for (i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            heaps heap = new heaps();
            heap.heapSort(arr, 10);
            Console.Write("\n Sorted Array is: ");
            for (i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
