using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zachet
{
    class Program
    {
        static void Main(string[] args)
        {
            QuickSort t = new QuickSort();

            HeapSort h = new HeapSort();
            int[] array = new int[] {1,5,2,5,23,7,9,5,1};

            //h.Sort(array);
            //t.QuickSort(array, 0, array.Length-1);

            foreach (int i in array)
            {
                Console.Write(i + "  ");
            }
            Console.WriteLine();
        }
    }
}
