/*
 Given a binary string s, return the number of non-empty substrings that have the same number of 0's and 1's, and all the 0's and all the 1's in these substrings are grouped consecutively.

Substrings that occur multiple times are counted the number of times they occur.

 

Example 1:

Input: s = "00110011"
Output: 6
Explanation: There are 6 substrings that have equal number of consecutive 1's and 0's: "0011", "01", "1100", "10", "0011", and "01".
Notice that some of these substrings repeat and are counted the number of times they occur.
Also, "00110011" is not a valid substring because all the 0's (and 1's) are not grouped together.
Example 2:

Input: s = "10101"
Output: 4
Explanation: There are 4 substrings: "10", "01", "10", "01" that have equal number of consecutive 1's and 0's.
 

Constraints:

1 <= s.length <= 105
s[i] is either '0' or '1'.
 */
namespace LeetCode;

public class CountBinarySubstrings
{
    public static int CountBinarySubstringsMethod(string s)
    {        
        int substrings = 0;
        int consecutiveZerosCount = 0;
        int consecutiveOnesCount = 0;
        char lastNumber = s[0];

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] != lastNumber && (consecutiveOnesCount > 0 && consecutiveZerosCount > 0))
            {
                if (s[i] == '0') consecutiveZerosCount = 0;
                else consecutiveOnesCount = 0;
            }

            if (s[i] == '0')
                consecutiveZerosCount++;
            else if (s[i] == '1')
                consecutiveOnesCount++;
            lastNumber = s[i];            

            if (consecutiveOnesCount > 0 && consecutiveZerosCount > 0)
            {
                substrings++;
                if (consecutiveZerosCount == consecutiveOnesCount)
                {
                    if (lastNumber == '0') consecutiveOnesCount = 0;
                    else consecutiveZerosCount = 0;
                }
            }
        }        
        return substrings;
    }
}
