namespace Misc.PalindromeChecker;

public class PalindromeChecker
{
    public bool IsPalindrome(string word)
    {
        if (word.Length <= 1) return false;

        int left = 0;
        int right = word.Length - 1;

        while (left != right)
        {
            if (word[left] != word[right])
                return false;
            left++;
            right--;
        }
        return true;
    }
}
