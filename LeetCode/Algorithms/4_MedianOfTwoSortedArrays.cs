using System;
using System.Linq;

namespace Algorithms
{
    //4. Median of Two Sorted Arrays
    //There are two sorted arrays nums1 and nums2 of size m and n respectively.
    //Find the median of the two sorted arrays.The overall run time complexity should be O(log (m+n)).
    //Example 1:
    //nums1 = [1, 3]
    //nums2 = [2]
    //The median is 2.0
    //Example 2:
    //nums1 = [1, 2]
    //nums2 = [3, 4]
    //The median is (2 + 3)/2 = 2.5

    public static class MedianOfTwoSortedArrays4
    {
        public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            var array = nums1.Concat(nums2).ToArray();
            Array.Sort(array);

            if (array.Length % 2 == 0)
            {
                var firstIndex = (array.Length / 2) - 1;
                var secondIndex = firstIndex + 1;

                return (array[firstIndex] + (double)array[secondIndex]) / 2;
            }
            else
            {
                var firstIndex = (int)Math.Ceiling((double)array.Length / 2);
                return array[firstIndex - 1];
            }
        }
    }
}
