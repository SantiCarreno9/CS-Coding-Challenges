/*
 Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.

An input string is valid if:

Open brackets must be closed by the same type of brackets.
Open brackets must be closed in the correct order.
Every close bracket has a corresponding open bracket of the same type.
 

Example 1:

Input: s = "()"

Output: true

Example 2:

Input: s = "()[]{}"

Output: true

Example 3:

Input: s = "(]"

Output: false

Example 4:

Input: s = "([])"

Output: true

Example 5:

Input: s = "([)]"

Output: false

 

Constraints:

1 <= s.length <= 104
s consists of parentheses only '()[]{}'.
 */
namespace LeetCode;

public static class ValidParentheses
{
    public static bool IsValid(string s)
    {
        if (s.Length % 2 != 0)
            return false;

        Dictionary<char, char> hashMap = new Dictionary<char, char> { { ')', '(' }, { ']', '[' }, { '}', '{' } };
        Stack<char> items = new Stack<char>();
        for (int i = 0; i < s.Length; i++)
        {
            var character = s[i];
            if (!hashMap.ContainsKey(character))
            {
                items.Push(character);
                continue;
            }

            if (items.Count == 0 || hashMap[character] != items.Pop())
            {
                return false;
            }
        }
        return items.Count == 0;
    }

}