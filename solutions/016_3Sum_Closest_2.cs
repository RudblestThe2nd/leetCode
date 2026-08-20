// 16 - 3Sum Closest - Medium
// Task: Find three numbers whose sum is closest to a target value.
// Official link: https://leetcode.com/problems/3sum-closest/
// Difficulty: Medium
// Question number: 16
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: Kaba kuvvet (Brute Force) - uc ic ice dongu ile tum ucluler
// denenir ve hedefe en yakin toplam takip edilir.
// Zaman Karmasikligi: O(n^3) - uc ic ice dongu.
// Alan Karmasikligi: O(1) - ek veri yapisi kullanilmaz.

using System;

public class Solution
{
    public int ThreeSumClosest(int[] sayilar, int hedef)
    {
        int uzunluk = sayilar.Length;
        int enYakinToplam = sayilar[0] + sayilar[1] + sayilar[2];
        int enKucukFark = Math.Abs(enYakinToplam - hedef);

        for (int birinci = 0; birinci < uzunluk - 2; birinci++)
        {
            for (int ikinci = birinci + 1; ikinci < uzunluk - 1; ikinci++)
            {
                for (int ucuncu = ikinci + 1; ucuncu < uzunluk; ucuncu++)
                {
                    int guncelToplam = sayilar[birinci] + sayilar[ikinci] + sayilar[ucuncu];
                    int fark = Math.Abs(guncelToplam - hedef);

                    if (fark < enKucukFark)
                    {
                        enKucukFark = fark;
                        enYakinToplam = guncelToplam;
                    }
                }
            }
        }

        return enYakinToplam;
    }
}
