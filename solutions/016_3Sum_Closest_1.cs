// 16 - 3Sum Closest - Medium
// Task: Find three numbers whose sum is closest to a target value.
// Official link: https://leetcode.com/problems/3sum-closest/
// Difficulty: Medium
// Question number: 16
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: Once diziyi sirala, sonra her eleman icin iki isaretci (two-pointer)
// yontemiyle en yakin toplami arayarak guncelle.
// Zaman Karmasikligi: O(n^2) - siralama O(n log n), ic dongu O(n^2).
// Alan Karmasikligi: O(1) - sabit ek alan (siralama haric).

using System;

public class Solution
{
    public int ThreeSumClosest(int[] sayilar, int hedef)
    {
        Array.Sort(sayilar);

        int enYakinToplam = sayilar[0] + sayilar[1] + sayilar[2];
        int uzunluk = sayilar.Length;

        for (int ilkIndeks = 0; ilkIndeks < uzunluk - 2; ilkIndeks++)
        {
            int sol = ilkIndeks + 1;
            int sag = uzunluk - 1;

            while (sol < sag)
            {
                int guncelToplam = sayilar[ilkIndeks] + sayilar[sol] + sayilar[sag];

                if (Math.Abs(guncelToplam - hedef) < Math.Abs(enYakinToplam - hedef))
                {
                    enYakinToplam = guncelToplam;
                }

                if (guncelToplam == hedef)
                {
                    return guncelToplam;
                }
                else if (guncelToplam < hedef)
                {
                    sol += 1;
                }
                else
                {
                    sag -= 1;
                }
            }
        }

        return enYakinToplam;
    }
}
