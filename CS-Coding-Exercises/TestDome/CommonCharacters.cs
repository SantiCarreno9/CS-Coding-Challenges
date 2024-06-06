/*
 Given a string array words, return an array of all characters that show up in all strings within the words (including duplicates). You may return the answer in any order.

 

Example 1:

Input: words = ["bella","label","roller"]
Output: ["e","l","l"]
Example 2:

Input: words = ["cool","lock","cook"]
Output: ["c","o"]
 

Constraints:

1 <= words.length <= 100
1 <= words[i].length <= 100
words[i] consists of lowercase English letters.
 */

namespace TestDome;

internal class CommonCharacters
{
    public static void Main(string[] args)
    {
        //var words = new string[] { "bella", "label", "roller" };
        var words = new string[] { "cool", "lock", "cook" };
        var common = CommonChars(words);
        foreach (var chars in common)
        {
            Console.WriteLine(chars);
        }
    }

    public static IList<string> CommonChars(string[] words)
    {
        if (words.Length < 1)
            return default;
        if (words.Length > 100)
            return default;

        List<string> repeated = new List<string>();
        for (int i = 0; i < words[0].Length; i++)
        {
            bool isRepeated = true;
            for (int j = 0; j < words.Length; j++)
            {
                if (words[j].Any(char.IsUpper))
                    return default;
                if (j == 0)
                    continue;
                if (!words[j].Contains(words[0][i]))
                {
                    isRepeated = false;
                    break;
                }
            }
            if (isRepeated)
            {
                repeated.Add(words[0][i].ToString());
            }
        }

        return repeated;
    }
}
