// 14 - Longest Common Prefix - Easy
// Task: Find the longest prefix shared by every string in an array.
// Official link: https://leetcode.com/problems/longest-common-prefix/
// Difficulty: Easy
// Question number: 14
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: Dikey tarama (Vertical Scanning) - her karakter pozisyonunda
// tum kelimeleri karsilastirir, ilk uyusmazlikta durur.
// Zaman Karmasikligi: O(n * m) - n kelime sayisi, m en kisa kelimenin uzunlugu.
// Alan Karmasikligi: O(1) - ek veri yapisi kullanilmaz.

using System;

public class Solution
{
    public string LongestCommonPrefix(string[] dizi)
    {
        if (dizi == null || dizi.Length == 0)
        {
            return "";
        }

        for (int karakterIndeksi = 0; karakterIndeksi < dizi[0].Length; karakterIndeksi++)
        {
            char karakter = dizi[0][karakterIndeksi];

            for (int kelimeIndeksi = 1; kelimeIndeksi < dizi.Length; kelimeIndeksi++)
            {
                if (karakterIndeksi >= dizi[kelimeIndeksi].Length || dizi[kelimeIndeksi][karakterIndeksi] != karakter)
                {
                    return dizi[0].Substring(0, karakterIndeksi);
                }
            }
        }

        return dizi[0];
    }
}
