// 3 - Longest Substring Without Repeating Characters - Medium
// Task: Find the length of the longest substring that contains no repeated characters.
// Official link: https://leetcode.com/problems/longest-substring-without-repeating-characters/
// Difficulty: Medium
// Question number: 3
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: Brute Force - her baslangic noktasindan itibaren tum alt dizileri kontrol et.
// Zaman Karmasikligi: O(n^3) - her alt dizi icin tekrar kontrolu de dahil.
// Alan Karmasikligi: O(min(n, k)) - karakter setini tutmak icin kullanilan kume.

using System.Collections.Generic;

public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        int uzunluk = s.Length;
        int enUzunSonuc = 0;

        for (int baslangic = 0; baslangic < uzunluk; baslangic++)
        {
            HashSet<char> gorulenler = new HashSet<char>();

            for (int bitis = baslangic; bitis < uzunluk; bitis++)
            {
                char karakter = s[bitis];

                if (gorulenler.Contains(karakter))
                {
                    break;
                }

                gorulenler.Add(karakter);

                int mevcutUzunluk = bitis - baslangic + 1;
                if (mevcutUzunluk > enUzunSonuc)
                {
                    enUzunSonuc = mevcutUzunluk;
                }
            }
        }

        return enUzunSonuc;
    }
}
