// 22 - Generate Parentheses - Medium
// Task: Generate every valid combination of n pairs of parentheses.
// Official link: https://leetcode.com/problems/generate-parentheses/
// Difficulty: Medium
// Question number: 22
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: Backtracking (geri izleme) - acik ve kapali parantez sayilarini
// takip ederek gecerli kombinasyonlari olustur, gecersiz dallari erken kes.
// Zaman Karmasikligi: O(4^n / sqrt(n)) - Catalan sayisi mertebesinde gecerli kombinasyon.
// Alan Karmasikligi: O(n) - ozyineleme derinligi ve gecici string icin.

using System;
using System.Collections.Generic;
using System.Text;

public class Solution
{
    public IList<string> GenerateParenthesis(int n)
    {
        var sonuc = new List<string>();
        var gecici = new StringBuilder();

        GeriIzle(gecici, 0, 0, n, sonuc);

        return sonuc;
    }

    private void GeriIzle(StringBuilder gecici, int acikSayisi, int kapaliSayisi, int n, List<string> sonuc)
    {
        if (gecici.Length == n * 2)
        {
            sonuc.Add(gecici.ToString());
            return;
        }

        if (acikSayisi < n)
        {
            gecici.Append('(');
            GeriIzle(gecici, acikSayisi + 1, kapaliSayisi, n, sonuc);
            gecici.Length -= 1;
        }

        if (kapaliSayisi < acikSayisi)
        {
            gecici.Append(')');
            GeriIzle(gecici, acikSayisi, kapaliSayisi + 1, n, sonuc);
            gecici.Length -= 1;
        }
    }
}
