/*
 Given a string s, return the longest palindromic substring in s.

 

Example 1:

Input: s = "babad"
Output: "bab"
Explanation: "aba" is also a valid answer.
Example 2:

Input: s = "cbbd"
Output: "bb"
 

Constraints:

1 <= s.length <= 1000
s consist of only digits and English letters.
 */
namespace LeetCode;
public class LongestPalindromeSearcher
{
    public string LongestPalindrome(string s)
    {
        if (s.Length <= 1) return s;

        int maxIndex = s.Length - 1;
        int left = 0;
        int right = 1;

        int currentLeft = 0;
        int currentRight = 0;
        int currentLongestPalindrome = 0;
        int numOfIterations = 0;
        while (numOfIterations < 100 && left != right)
        {
            if (s[left] == s[right] && (left == right - 1 || s[left + 1] == s[right - 1]))
            {
                if (right - left > currentLongestPalindrome)
                {
                    currentLeft = left;
                    currentRight = right;
                    currentLongestPalindrome = currentRight - currentLeft;
                }
                if (left == 0 && right == maxIndex) break;
                left--;
                right++;
            }
            else
            {
                if (maxIndex - right < currentLongestPalindrome) break;

                if (currentLongestPalindrome > 0)
                {
                    if (currentLeft > left)
                    {
                        left = currentLeft;
                        right++;
                    }
                }


                if (left == right - 1)
                    right++;
                else
                {
                    left = right - 1;
                }
                //    left = right;
                //right++;
                //if (right - left > 1 || right == maxIndex)
                //{
                //    if (maxIndex - right < currentLongestPalindrome) break;
                //    left++;
                //}                    
                //else
                //    right++;
            }

            if (left < 0) left = 0;
            if (right > maxIndex) right = maxIndex;
            numOfIterations++;
        }
        return s.Substring(currentLeft, currentRight - currentLeft + 1);
    }
}
