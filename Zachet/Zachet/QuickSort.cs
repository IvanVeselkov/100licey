using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zachet
{
    class QuickSort
    {
        public void Sort(int[] array, int first, int last)
        {
            int mid, count;
            int f = first, l = last;
            mid = array[(f + l) / 2];
            do
            {
                while (array[f] < mid)
                    f++;
                while (array[l] > mid)
                    l--;
                if (f <= l)
                {
                    count = array[f];
                    array[f] = array[l];
                    array[l] = count;
                    f++;
                    l--;
                }
            } while (f < l);
            if (first < l)
                Sort(array, first, l);
            if (f < last)
                Sort(array, f, last);

        }
    }
}
