/*
 Given a string containing digits from 2-9 inclusive, return all possible letter combinations that the number could represent. Return the answer in any order.

A mapping of digits to letters (just like on the telephone buttons) is given below. Note that 1 does not map to any letters.


 

Example 1:

Input: digits = "23"
Output: ["ad","ae","af","bd","be","bf","cd","ce","cf"]
Example 2:

Input: digits = "2"
Output: ["a","b","c"]
 

Constraints:

1 <= digits.length <= 4
digits[i] is a digit in the range ['2', '9'].
 */
using System.Text;

namespace LeetCode;

public class LetterCombinationsPhoneNumber
{
    public static IList<string> LetterCombinations(string digits)
    {
        if (string.IsNullOrEmpty(digits)) return [];
        byte digitsCount = (byte)digits.Length;
        var list = new List<string>();

        string[] phoneAlphabet =
        [
            "abc",
            "def",
            "ghi",
            "jkl",
            "mno",
            "pqrs",
            "tuv",
            "wxyz",
        ];
        string[] digitsAlphabet = new string[digitsCount];
        byte[] indexPosition = new byte[digitsCount];
        byte maxCombinations = 1;
        for (int i = 0; i < digitsCount; i++)
        {
            var numberIndex = digits[i] - 50;
            digitsAlphabet[i] = phoneAlphabet[numberIndex];
            indexPosition[i] = 0;
            maxCombinations *= (byte)phoneAlphabet[numberIndex].Length;
        }

        byte[] combinationsToGrow = new byte[digitsCount];
        for (int i = digitsCount - 1; i >= 0; i--)
        {
            if (i < digitsCount - 1)
                combinationsToGrow[i] = (byte)(combinationsToGrow[i + 1] * digitsAlphabet[i + 1].Length);
            else combinationsToGrow[i] = 1;
        }


        byte combinationsCount = 0;
        StringBuilder stringBuilder = new StringBuilder();
        combinationsCount = 1;
        while (combinationsCount < maxCombinations + 1)
        {
            for (int i = 0; i < digitsCount; i++)
            {
                if (indexPosition[i] > digitsAlphabet[i].Length - 1)
                {
                    indexPosition[i] = 0;
                }
                byte index = indexPosition[i];
                stringBuilder.Append(digitsAlphabet[i][index]);
                if (combinationsCount % combinationsToGrow[i] == 0)
                    indexPosition[i]++;
            }
            list.Add(stringBuilder.ToString());
            stringBuilder.Clear();
            combinationsCount++;
        }
        return list;
    }
}
