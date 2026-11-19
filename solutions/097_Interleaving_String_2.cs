// 97 - Interleaving String - Medium
// Task: Determine whether a string can be formed by interleaving two other strings while preserving their internal order.
// Official link: https://leetcode.com/problems/interleaving-string/
// Difficulty: Medium
// Question number: 97
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: Recursive (ozyinelemeli) DFS + bellekleme (memoization).
// Her (i, j) konumundan basarisiz sonucu tekrar hesaplamamak icin harita kullanilir.
// Zaman Karmasikligi: O(uzunluk1 * uzunluk2) - her durum en fazla bir kez hesaplanir.
// Alan Karmasikligi: O(uzunluk1 * uzunluk2) - bellekleme haritasi ve cagri yigini icin.

using System.Collections.Generic;

public class Solution
{
    private Dictionary<long, bool> bellek;
    private string s1;
    private string s2;
    private string s3;

    public bool IsInterleave(string s1, string s2, string s3)
    {
        if (s1.Length + s2.Length != s3.Length)
        {
            return false;
        }

        this.s1 = s1;
        this.s2 = s2;
        this.s3 = s3;
        bellek = new Dictionary<long, bool>();

        return Kontrol(0, 0);
    }

    private bool Kontrol(int i, int j)
    {
        if (i == s1.Length && j == s2.Length)
        {
            return true;
        }

        long anahtar = (long)i * 100001 + j;

        if (bellek.ContainsKey(anahtar))
        {
            return bellek[anahtar];
        }

        bool sonuc = false;

        if (i < s1.Length && s1[i] == s3[i + j] && Kontrol(i + 1, j))
        {
            sonuc = true;
        }

        if (!sonuc && j < s2.Length && s2[j] == s3[i + j] && Kontrol(i, j + 1))
        {
            sonuc = true;
        }

        bellek[anahtar] = sonuc;

        return sonuc;
    }
}
