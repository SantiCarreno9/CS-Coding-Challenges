namespace LeetCode;
public class IntegerToRoman
{
    public string IntToRoman(int num)
    {
        var romanNumbers = new Dictionary<int, string>() {
            { 1, "I" },
            { 5, "V" },
            { 10, "X" },
            { 50, "L" },
            { 100, "C" },
            { 500, "D" },
            { 1000, "M" }
        };

        string romanNumber = "";
        int factor = 10000;

        while (factor > 1)
        {
            factor = factor / 10;
            int digit = num / factor;
            if (digit == 0)
                continue;

            int valueWithFactor = digit * factor;
            num -= valueWithFactor;

            if (romanNumbers.TryGetValue(valueWithFactor, out var value))
            {
                romanNumber += value;
                continue;
            }

            if (digit == 4 || digit == 9)
            {
                romanNumber += romanNumbers[factor];
                romanNumber += romanNumbers[(digit == 4 ? 5 : 10) * factor];
                continue;
            }

            int times = 0;

            if (digit < 4)
                times = valueWithFactor / factor;
            else
            {
                times = digit - 5;
                romanNumber += romanNumbers[5 * factor];
            }

            while (times > 0)
            {
                romanNumber += romanNumbers[factor];
                times--;
            }            
        }

        return romanNumber;
    }
}
