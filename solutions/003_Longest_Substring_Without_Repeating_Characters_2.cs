// 3 - Longest Substring Without Repeating Characters - Medium
// Task: Find the length of the longest substring that contains no repeated characters.
// Official link: https://leetcode.com/problems/longest-substring-without-repeating-characters/
// Difficulty: Medium
// Question number: 3
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: Kayan Pencere (Sliding Window) - iki isaretci ve harita ile tek gecis.
// Zaman Karmasikligi: O(n) - her karakter en fazla iki kez ziyaret edilir.
// Alan Karmasikligi: O(min(n, k)) - karakterlerin son gorulen indekslerini tutan harita.

using System.Collections.Generic;

public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        Dictionary<char, int> sonGorulenIndeks = new Dictionary<char, int>();
        int sol = 0;
        int enUzunSonuc = 0;

        for (int sag = 0; sag < s.Length; sag++)
        {
            char karakter = s[sag];

            if (sonGorulenIndeks.ContainsKey(karakter) && sonGorulenIndeks[karakter] >= sol)
            {
                sol = sonGorulenIndeks[karakter] + 1;
            }

            sonGorulenIndeks[karakter] = sag;

            int pencereUzunlugu = sag - sol + 1;
            if (pencereUzunlugu > enUzunSonuc)
            {
                enUzunSonuc = pencereUzunlugu;
            }
        }

        return enUzunSonuc;
    }
}
