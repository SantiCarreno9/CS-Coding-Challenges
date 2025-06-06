/*
 Given two sorted arrays nums1 and nums2 of size m and n respectively, return the median of the two sorted arrays.

The overall run time complexity should be O(log (m+n)).

 

Example 1:

Input: nums1 = [1,3], nums2 = [2]
Output: 2.00000
Explanation: merged array = [1,2,3] and median is 2.
Example 2:

Input: nums1 = [1,2], nums2 = [3,4]
Output: 2.50000
Explanation: merged array = [1,2,3,4] and median is (2 + 3) / 2 = 2.5.
 

Constraints:

nums1.length == m
nums2.length == n
0 <= m <= 1000
0 <= n <= 1000
1 <= m + n <= 2000
-106 <= nums1[i], nums2[i] <= 106
 */

namespace LeetCode;

public class MedianOfTwoArrays
{
    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        int[] nums3 = new int[nums1.Length + nums2.Length];
        int k = 0;
        int l = 0;
        int r = 0;

        while (l < nums1.Length && r < nums2.Length)
        {
            if (nums1[l] <= nums2[r])
            {
                nums3[k] = nums1[l];
                l++;
            }
            else
            {
                nums3[k] = nums2[r];
                r++;
            }
            k++;
        }

        while (l < nums1.Length)
        {
            nums3[k] = nums1[l];
            l++;
            k++;
        }

        while (r < nums2.Length)
        {
            nums3[k] = nums2[r];
            r++;
            k++;
        }

        int n = nums3.Length;
        double median = (n % 2 == 0) ?
                       (double)(nums3[n / 2] + nums3[(n / 2) - 1]) / 2
                                      : nums3[((n + 1) / 2) - 1];
        return median;

    }
}
