namespace TestDome;

public class PalindromeChecker
{
    public static bool IsPalindrome(string word)
    {
        if (word.Length <= 1)
            return true;

        string finalWord = word.ToLower();
        finalWord = finalWord.Replace(" ", "");

        if (finalWord[0] == finalWord[finalWord.Length - 1])
            return IsPalindrome(finalWord.Substring(1, finalWord.Length - 2));
        else return false;
    }

    //public static void Main(string[] args)
    //{
    //    string[] words = { "Oso", "longest", "common" , "rAdar", "Anita lava la Tina", "level", "rotor" };
    //    for (int i = 0; i < words.Length; i++)
    //    {
    //        string complement = (IsPalindrome(words[i])) ? "palindrome" : "not palindrome";
    //        Console.WriteLine($"{words[i]} is {complement}");
    //    }
    //}
}
