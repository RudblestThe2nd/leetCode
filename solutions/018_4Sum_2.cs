// 18 - 4Sum - Medium
// Task: Find all unique quadruplets in an array whose values sum to a target.
// Official link: https://leetcode.com/problems/4sum/
// Difficulty: Medium
// Question number: 18
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: Backtracking (geri izleme) tabanli genel k-Sum cozumu.
// Diziyi sirala, ozyinelemeli olarak 4 eleman secip hedefe ulasmaya calis.
// Zaman Karmasikligi: O(n^3) - genel olarak k=4 icin ozyinelemeli tarama.
// Alan Karmasikligi: O(n) - ozyineleme yigini ve gecici liste icin.

using System;
using System.Collections.Generic;

public class Solution
{
    public IList<IList<int>> FourSum(int[] sayilar, int hedef)
    {
        var sonuc = new List<IList<int>>();

        Array.Sort(sayilar);

        var gecici = new List<int>();

        GeriIzle(sayilar, 0, 4, hedef, gecici, sonuc);

        return sonuc;
    }

    private void GeriIzle(int[] sayilar, int baslangic, int kalanAdet, long hedef, List<int> gecici, List<IList<int>> sonuc)
    {
        int uzunluk = sayilar.Length;

        if (kalanAdet == 0)
        {
            if (hedef == 0)
            {
                sonuc.Add(new List<int>(gecici));
            }

            return;
        }

        for (int indeks = baslangic; indeks <= uzunluk - kalanAdet; indeks++)
        {
            if (indeks > baslangic && sayilar[indeks] == sayilar[indeks - 1])
            {
                continue;
            }

            long minOlasiToplam = (long)sayilar[indeks] * kalanAdet;
            long maxOlasiToplam = (long)sayilar[uzunluk - 1] * kalanAdet;

            if (minOlasiToplam > hedef || maxOlasiToplam < hedef)
            {
                break;
            }

            gecici.Add(sayilar[indeks]);

            GeriIzle(sayilar, indeks + 1, kalanAdet - 1, hedef - sayilar[indeks], gecici, sonuc);

            gecici.RemoveAt(gecici.Count - 1);
        }
    }
}
