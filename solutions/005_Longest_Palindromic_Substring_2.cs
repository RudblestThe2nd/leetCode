// 5 - Longest Palindromic Substring - Medium
// Task: Return the longest substring of a given string that reads the same forward and backward.
// Official link: https://leetcode.com/problems/longest-palindromic-substring/
// Difficulty: Medium
// Question number: 5
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: Merkezden Genisleme (Expand Around Center) - her merkez icin tek ve cift uzunlukta genislet.
// Zaman Karmasikligi: O(n^2) - her merkez icin genisleme islemi.
// Alan Karmasikligi: O(1) - ekstra veri yapisi kullanilmaz.

public class Solution
{
    public string LongestPalindrome(string s)
    {
        if (s.Length == 0)
        {
            return "";
        }

        int enIyiBaslangic = 0;
        int enIyiUzunluk = 1;

        for (int merkez = 0; merkez < s.Length; merkez++)
        {
            int tekUzunluk = GenisletVeOlc(s, merkez, merkez);
            if (tekUzunluk > enIyiUzunluk)
            {
                enIyiUzunluk = tekUzunluk;
                enIyiBaslangic = merkez - (tekUzunluk - 1) / 2;
            }

            int ciftUzunluk = GenisletVeOlc(s, merkez, merkez + 1);
            if (ciftUzunluk > enIyiUzunluk)
            {
                enIyiUzunluk = ciftUzunluk;
                enIyiBaslangic = merkez - ciftUzunluk / 2 + 1;
            }
        }

        return s.Substring(enIyiBaslangic, enIyiUzunluk);
    }

    private int GenisletVeOlc(string s, int sol, int sag)
    {
        while (sol >= 0 && sag < s.Length && s[sol] == s[sag])
        {
            sol--;
            sag++;
        }

        return sag - sol - 1;
    }
}
