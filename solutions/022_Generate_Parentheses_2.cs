// 22 - Generate Parentheses - Medium
// Task: Generate every valid combination of n pairs of parentheses.
// Official link: https://leetcode.com/problems/generate-parentheses/
// Difficulty: Medium
// Question number: 22
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: Dinamik Programlama (DP) - kucuk n degerleri icin sonuclari
// hesaplayip, daha buyuk n degerlerini onceki sonuclarin birlesimiyle uretir.
// Her k icin: "(" + (k-1 ic kisim) + ")" + (n-k disarida kalan kisim).
// Zaman Karmasikligi: O(4^n / sqrt(n)) - Catalan sayisi mertebesinde gecerli kombinasyon.
// Alan Karmasikligi: O(4^n / sqrt(n)) - tum ara sonuclarin saklanmasi icin.

using System;
using System.Collections.Generic;

public class Solution
{
    public IList<string> GenerateParenthesis(int n)
    {
        var tumSonuclar = new List<List<string>>();

        tumSonuclar.Add(new List<string> { "" });

        for (int mevcutN = 1; mevcutN <= n; mevcutN++)
        {
            var buAdimSonuclari = new List<string>();

            for (int icKisimUzunlugu = 0; icKisimUzunlugu < mevcutN; icKisimUzunlugu++)
            {
                int disKisimUzunlugu = mevcutN - 1 - icKisimUzunlugu;

                foreach (string icKisim in tumSonuclar[icKisimUzunlugu])
                {
                    foreach (string disKisim in tumSonuclar[disKisimUzunlugu])
                    {
                        buAdimSonuclari.Add("(" + icKisim + ")" + disKisim);
                    }
                }
            }

            tumSonuclar.Add(buAdimSonuclari);
        }

        return tumSonuclar[n];
    }
}
