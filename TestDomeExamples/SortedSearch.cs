using System;
using System.Collections.Generic;
using System.Linq;

public class SortedSearch
{
    public static int CountNumbers(int[] sortedArray, int lessThan)
    {
        int length = sortedArray.Length;
        if (length == 0)
            return 0;

        //Is the first item greater than lessThan
        if (sortedArray[0] >= lessThan)
            return 0;

        //Is the last item less than lessThan
        if (sortedArray[length - 1] < lessThan)
            return length;        

        int mid = (length / 2);

        if (sortedArray[mid] >= lessThan)
        {
            for (int i = mid - 1; i >= 0; i--)
            {
                if (sortedArray[i] >= lessThan)
                    continue;
                return (i + 1);
            }
        }
        else
        {
            for (int i = mid + 1; i < length; i++)
            {
                if (sortedArray[i] < lessThan)
                    continue;
                return i;
            }
        }

        return 0;        
    }

    //public static void Main(string[] args)
    //{
    //    Console.WriteLine(SortedSearch.CountNumbers(new int[] { 1, 3, 5, 7 }, 4));//Example        
    //    //Console.WriteLine(SortedSearch.CountNumbers(new int[] { 1, 3, 4, 4, 5, 7 }, 4));
    //    //Console.WriteLine();

    //    //Console.WriteLine(SortedSearch.CountNumbers(new int[] { 1 }, 4));
    //    //Console.WriteLine(SortedSearch.CountNumbers(new int[] { 4 }, 4));
    //    //Console.WriteLine(SortedSearch.CountNumbers(new int[] { 5 }, 4));
    //    //Console.WriteLine();

    //    //Console.WriteLine(SortedSearch.CountNumbers(new int[] { 1, 3 }, 4));
    //    //Console.WriteLine(SortedSearch.CountNumbers(new int[] { 1, 4 }, 4));
    //    //Console.WriteLine(SortedSearch.CountNumbers(new int[] { 1, 5 }, 4));
    //    //Console.WriteLine();

    //    Console.WriteLine(SortedSearch.CountNumbers(new int[] { 1, 2, 3 }, 4));
    //    Console.WriteLine(SortedSearch.CountNumbers(new int[] { 1, 2, 4 }, 4));
    //    Console.WriteLine(SortedSearch.CountNumbers(new int[] { 1, 2, 5 }, 4));
    //    Console.WriteLine();

    //    Console.WriteLine(SortedSearch.CountNumbers(new int[] { 1, 4, 5 }, 4));
    //    Console.WriteLine(SortedSearch.CountNumbers(new int[] { 4, 5, 6 }, 4));
    //    Console.WriteLine(SortedSearch.CountNumbers(new int[] { 5, 6, 7 }, 4));
    //    Console.WriteLine();

    //    Console.WriteLine(SortedSearch.CountNumbers(new int[] { 1, 4, 4, 4, 4, 4, 4, 5 }, 4));
    //    Console.WriteLine();
    //}
}