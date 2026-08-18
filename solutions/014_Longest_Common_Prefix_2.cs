// 14 - Longest Common Prefix - Easy
// Task: Find the longest prefix shared by every string in an array.
// Official link: https://leetcode.com/problems/longest-common-prefix/
// Difficulty: Easy
// Question number: 14
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: Ikiye bolerek (Divide and Conquer) - diziyi ortadan ikiye bolup
// her yarinin ortak onekini bulur, sonra iki sonucu birlestirir.
// Zaman Karmasikligi: O(n * m) - n kelime sayisi, m en kisa kelimenin uzunlugu.
// Alan Karmasikligi: O(log n) - ozyineleme (recursion) yigini icin.

using System;

public class Solution
{
    public string LongestCommonPrefix(string[] dizi)
    {
        if (dizi == null || dizi.Length == 0)
        {
            return "";
        }

        return BolVeYonet(dizi, 0, dizi.Length - 1);
    }

    private string BolVeYonet(string[] dizi, int sol, int sag)
    {
        if (sol == sag)
        {
            return dizi[sol];
        }

        int orta = (sol + sag) / 2;

        string solSonuc = BolVeYonet(dizi, sol, orta);
        string sagSonuc = BolVeYonet(dizi, orta + 1, sag);

        return OrtakOnekiBul(solSonuc, sagSonuc);
    }

    private string OrtakOnekiBul(string birinci, string ikinci)
    {
        int minUzunluk = Math.Min(birinci.Length, ikinci.Length);
        int indeks = 0;

        while (indeks < minUzunluk && birinci[indeks] == ikinci[indeks])
        {
            indeks += 1;
        }

        return birinci.Substring(0, indeks);
    }
}
