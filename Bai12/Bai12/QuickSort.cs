using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai12
{
    public class QuickSort
    {
        public static void quickSort(int[] list, int left, int right)
        {
            if (left >= right)
            {
                return;
            }
            int pivot = list[(left + right) / 2];
            int index = partition(list, left, right, pivot);
            quickSort(list, left, index - 1);
            quickSort(list, index, right);
        }

        private static int partition(int[] list, int left, int right, int pivot)
        {
            while (left <= right)
            {
                while (list[left] < pivot)
                {
                    left++;
                }
                while (list[right] > pivot)
                {
                    right--;
                }
                if (left <= right)
                {
                    int temp = list[left];
                    list[left] = list[right];
                    list[right] = temp;
                    left++;
                    right--;
                }
            }
            return left;
        }
    }
}
