/*
 Given a string s, find the length of the longest 
substring
 without repeating characters.

Example 1:

Input: s = "abcabcbb"
Output: 3
Explanation: The answer is "abc", with the length of 3.
Example 2:

Input: s = "bbbbb"
Output: 1
Explanation: The answer is "b", with the length of 1.
Example 3:

Input: s = "pwwkew"
Output: 3
Explanation: The answer is "wke", with the length of 3.
Notice that the answer must be a substring, "pwke" is a subsequence and not a substring.
 

Constraints:

0 <= s.length <= 5 * 104
s consists of English letters, digits, symbols and spaces.
 */
namespace LeetCode;

public class LongestSubstring
{
    public int LengthOfLongestSubstring(string s)
    {
        //Memory = 42.6MB - Time = 65ms
        if (s.Length <= 1)
            return s.Length;        
        HashSet<char> hashSet = new HashSet<char>();
        Queue<char> queue = new Queue<char>();
        int maxLength = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (!hashSet.Add(s[i]))
            {
                if (hashSet.Count > maxLength)
                    maxLength = hashSet.Count;

                char c;
                do
                {
                    c = queue.Dequeue();
                    hashSet.Remove(c);
                } while (c != s[i]);
                hashSet.Add(s[i]);
            }
            queue.Enqueue(s[i]);
        }
        if (hashSet.Count > maxLength)
            maxLength = hashSet.Count;
        return maxLength;

        //Memory = 42.4MB - Time = 66ms
        //if (s.Length <= 1)
        //    return s.Length;
        //Dictionary<char, int> dictionary = new Dictionary<char, int>();
        //int maxLength = 0;
        //int currentLength = 0;
        //for (int i = 0; i < s.Length; i++)
        //{
        //    if (!dictionary.TryAdd(s[i], i))
        //    {
        //        if (currentLength > maxLength)
        //            maxLength = currentLength;

        //        currentLength = 0;
        //        i = dictionary[s[i]];
        //        if (maxLength > (s.Length - (i + 1)))
        //            break;
        //        dictionary.Clear();
        //    }
        //    else currentLength++;
        //}
        //if (currentLength > maxLength)
        //    maxLength = currentLength;
        //return maxLength;

        //Memory = 42.17 MB - Time = 75 ms
        //if (s.Length <= 1)
        //    return s.Length;
        //Dictionary<char, int> dictionary = new Dictionary<char, int>();
        //int maxLength = 0;
        //int currentLength = 0;
        //for (int i = 0; i < s.Length; i++)
        //{
        //    if (!dictionary.TryAdd(s[i], i))
        //    {
        //        if (currentLength > maxLength)
        //            maxLength = currentLength;

        //        currentLength = 0;
        //        i = dictionary[s[i]];
        //        dictionary.Clear();
        //    }
        //    else currentLength++;
        //}
        //if (currentLength > maxLength)
        //    maxLength = currentLength;
        //return maxLength;
    }
}
