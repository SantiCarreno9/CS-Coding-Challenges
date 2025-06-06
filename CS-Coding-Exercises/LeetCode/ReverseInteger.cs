/*
Given a signed 32-bit integer x, return x with its digits reversed. If reversing x causes the value to go outside the signed 32-bit integer range [-231, 231 - 1], then return 0.

Assume the environment does not allow you to store 64-bit integers (signed or unsigned).

 

Example 1:

Input: x = 123
Output: 321
Example 2:

Input: x = -123
Output: -321
Example 3:

Input: x = 120
Output: 21
 

Constraints:

-231 <= x <= 231 - 1
 */

namespace LeetCode;
public class ReverseInteger
{
    public int Reverse(int x)
    {
        if (x < -Int32.MaxValue || x > Int32.MaxValue)
            return 0;

        var numToString = x.ToString();
        int numOfZeros = numToString.Length - 1;
        numOfZeros -= (x < 0) ? 1 : 0;

        if (numOfZeros == 0)
            return x;

        double digit = numToString[^1] - '0';
        digit *= Math.Pow(10, numOfZeros);
        if (digit > Int32.MaxValue)
            return 0;


        int sign = x < 0 ? -1 : 1;
        double result = (sign * digit + Reverse(x / 10));
        if (result > Int32.MaxValue || result < -Int32.MaxValue)
            return 0;
        return (int)result;
    }
}
