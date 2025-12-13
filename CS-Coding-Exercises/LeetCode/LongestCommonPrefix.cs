/*
Write a function to find the longest common prefix string amongst an array of strings.

If there is no common prefix, return an empty string "".

 

Example 1:

Input: strs = ["flower","flow","flight"]
Output: "fl"
Example 2:

Input: strs = ["dog","racecar","car"]
Output: ""
Explanation: There is no common prefix among the input strings.
 

Constraints:

1 <= strs.length <= 200
0 <= strs[i].length <= 200
strs[i] consists of only lowercase English letters if it is non-empty.
*/

using System.Text;

namespace LeetCode;

public static class LongestCommonPrefix
{
    public static string LongestCommonPrefixMethod(string[] strs)
    {
        StringBuilder prefix = new StringBuilder("");
        int index = 0;
        while (index < strs[0].Length)
        {
            char character = '-';
            for (int i = 0; i < strs.Length; i++)
            {
                if (index > strs[i].Length - 1)
                    return prefix.ToString();

                if (i == 0)
                {
                    character = strs[i][index];
                    continue;
                }

                if (strs[i][index] != character)
                    return prefix.ToString();

            }
            index++;
            prefix.Append(character);
        }
        return prefix.ToString();
    }
}