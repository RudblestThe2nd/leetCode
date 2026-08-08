// 5 - Longest Palindromic Substring - Medium
// Task: Return the longest substring of a given string that reads the same forward and backward.
// Official link: https://leetcode.com/problems/longest-palindromic-substring/
// Difficulty: Medium
// Question number: 5
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: Brute Force - tum alt dizileri denetleyip palindrom olanlardan en uzununu bul.
// Zaman Karmasikligi: O(n^3) - her alt dizi icin palindrom kontrolu.
// Alan Karmasikligi: O(1) - ekstra veri yapisi kullanilmaz.

public class Solution
{
    public string LongestPalindrome(string s)
    {
        int uzunluk = s.Length;

        if (uzunluk == 0)
        {
            return "";
        }

        int enIyiBaslangic = 0;
        int enIyiUzunluk = 1;

        for (int baslangic = 0; baslangic < uzunluk; baslangic++)
        {
            for (int bitis = baslangic; bitis < uzunluk; bitis++)
            {
                int mevcutUzunluk = bitis - baslangic + 1;

                if (mevcutUzunluk > enIyiUzunluk && PalindromMu(s, baslangic, bitis))
                {
                    enIyiBaslangic = baslangic;
                    enIyiUzunluk = mevcutUzunluk;
                }
            }
        }

        return s.Substring(enIyiBaslangic, enIyiUzunluk);
    }

    private bool PalindromMu(string s, int sol, int sag)
    {
        while (sol < sag)
        {
            if (s[sol] != s[sag])
            {
                return false;
            }
            sol++;
            sag--;
        }

        return true;
    }
}
