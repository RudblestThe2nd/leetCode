// 9 - Palindrome Number - Easy
// Task: Determine whether an integer is a palindrome without relying on a string conversion if possible.
// Official link: https://leetcode.com/problems/palindrome-number/
// Difficulty: Easy
// Question number: 9
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: Metne Cevirme - sayiyi metne cevirip bastan ve sondan karsilastir.
// Zaman Karmasikligi: O(n) - basamak sayisi kadar karsilastirma.
// Alan Karmasikligi: O(n) - sayinin metin karsiligi icin kullanilan alan.

public class Solution
{
    public bool IsPalindrome(int x)
    {
        if (x < 0)
        {
            return false;
        }

        string metin = x.ToString();
        int sol = 0;
        int sag = metin.Length - 1;

        while (sol < sag)
        {
            if (metin[sol] != metin[sag])
            {
                return false;
            }
            sol++;
            sag--;
        }

        return true;
    }
}
