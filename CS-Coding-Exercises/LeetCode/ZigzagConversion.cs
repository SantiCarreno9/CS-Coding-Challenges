using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode;

public class ZigzagConversion
{
    public string Convert(string s, int numRows)
    {        
        if (numRows == 1 || numRows >= s.Length)
            return s;
        var strings = new string[numRows];
        var letterCount = 0;
        var index = 0;
        var direction = 1;
        while (letterCount < s.Length)
        {
            if (index == 0)
                direction = 1;
            if (index == numRows - 1)
                direction = -1;
            strings[index] += s[letterCount];
            index += direction;
            letterCount++;
        }

        string result = "";
        for (int i = 0; i < numRows; i++)
        {
            result += strings[i];
        }
        return result;
    }
}
