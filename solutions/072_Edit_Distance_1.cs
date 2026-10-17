// 72 - Edit Distance - Medium
// Task: Compute the minimum number of insert, delete, and replace operations needed to convert one word into another.
// Official link: https://leetcode.com/problems/edit-distance/
// Difficulty: Medium
// Question number: 72
// Note: This is a concise paraphrase, not a copied full LeetCode statement.

// Yaklasim: 2D DP (tam dp[][] matrisi ile)
// Zaman Karmasikligi: O(birinciUzunluk * ikinciUzunluk)
// Alan Karmasikligi: O(birinciUzunluk * ikinciUzunluk)
// Aciklama: dp[satir, sutun), birinci kelimenin ilk 'satir' karakteri ile
// ikinci kelimenin ilk 'sutun' karakteri arasindaki minimum duzenleme
// uzakligini tutar. Karakterler esitse capraz deger kullanilir, degilse ekle,
// sil, degistir islemlerinin en az maliyetlisi secilir.

using System;

public class Solution
{
    public int MinDistance(string birinciKelime, string ikinciKelime)
    {
        int birinciUzunluk = birinciKelime.Length;
        int ikinciUzunluk = ikinciKelime.Length;

        int[,] dp = new int[birinciUzunluk + 1, ikinciUzunluk + 1];

        for (int satir = 0; satir <= birinciUzunluk; satir++)
        {
            dp[satir, 0] = satir;
        }

        for (int sutun = 0; sutun <= ikinciUzunluk; sutun++)
        {
            dp[0, sutun] = sutun;
        }

        for (int satir = 1; satir <= birinciUzunluk; satir++)
        {
            for (int sutun = 1; sutun <= ikinciUzunluk; sutun++)
            {
                if (birinciKelime[satir - 1] == ikinciKelime[sutun - 1])
                {
                    dp[satir, sutun] = dp[satir - 1, sutun - 1];
                }
                else
                {
                    int silme = dp[satir - 1, sutun] + 1;
                    int ekleme = dp[satir, sutun - 1] + 1;
                    int degistirme = dp[satir - 1, sutun - 1] + 1;

                    dp[satir, sutun] = Math.Min(silme, Math.Min(ekleme, degistirme));
                }
            }
        }

        return dp[birinciUzunluk, ikinciUzunluk];
    }
}
